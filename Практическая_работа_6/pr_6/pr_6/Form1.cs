using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace pr_6
{
    public partial class Form1 : Form
    {
        private class DecisionNode
        {
            public string Question { get; set; }
            public string Result { get; set; }
            public DecisionNode YesNode { get; set; }
            public DecisionNode NoNode { get; set; }
            public TreeNode TreeViewItem { get; set; }
            public bool IsLeaf => Result != null;
        }

        private DecisionNode _root;
        private DecisionNode _currentNode;
        private Stack<DecisionNode> _history;
        private List<string> _answerHistory;

        public Form1()
        {
            InitializeComponent();
            InitializeDecisionTree();
            SetupTreeView();
            ResetApplication();
        }

        private void InitializeDecisionTree()
        {
            var launchProduct = new DecisionNode
            {
                Result = "✅ РЕКОМЕНДАЦИЯ: Запускайте продукт!\nРынок готов, бюджет и команда на месте."
            };

            var trainTeam = new DecisionNode
            {
                Result = "⚠️ РЕКОМЕНДАЦИЯ: Сначала обучите команду.\nПосле подготовки — можно запускать."
            };

            var seekFunding = new DecisionNode
            {
                Result = "💰 РЕКОМЕНДАЦИЯ: Найдите дополнительное финансирование.\nБез бюджета запуск рискован."
            };

            var researchMarket = new DecisionNode
            {
                Result = "📊 РЕКОМЕНДАЦИЯ: Проведите исследование рынка.\nЗапуск без спроса нецелесообразен."
            };

            var pivotProduct = new DecisionNode
            {
                Result = "🔄 РЕКОМЕНДАЦИЯ: Пересмотрите концепцию продукта.\nВысокие риски и низкий потенциал."
            };

            var teamReady = new DecisionNode
            {
                Question = "Команда готова к запуску?",
                YesNode = launchProduct,
                NoNode = trainTeam
            };

            var budgetSufficient = new DecisionNode
            {
                Question = "Бюджет достаточен?",
                YesNode = teamReady,
                NoNode = seekFunding
            };

            var marketDemand = new DecisionNode
            {
                Question = "Есть подтверждённый спрос на продукт?",
                YesNode = budgetSufficient,
                NoNode = researchMarket
            };

            var competitionHigh = new DecisionNode
            {
                Question = "Высокая конкуренция на рынке?",
                YesNode = pivotProduct,
                NoNode = marketDemand
            };

            _root = new DecisionNode
            {
                Question = "Рассматриваете ли вы запуск нового продукта?",
                YesNode = competitionHigh,
                NoNode = new DecisionNode { Result = "ℹ️ Возвращайтесь, когда будете готовы к анализу." }
            };
        }

        private void SetupTreeView()
        {
            treeViewDecision.BeginUpdate();
            treeViewDecision.Nodes.Clear();
            BuildTreeViewNodes(_root, null);
            treeViewDecision.EndUpdate();
            treeViewDecision.ExpandAll();
        }

        private void BuildTreeViewNodes(DecisionNode node, TreeNode parent)
        {
            string nodeText = node.IsLeaf ? $"🎯 Результат" : $"❓ {node.Question}";
            var treeNode = new TreeNode(nodeText);
            node.TreeViewItem = treeNode;

            if (parent == null)
                treeViewDecision.Nodes.Add(treeNode);
            else
                parent.Nodes.Add(treeNode);

            if (!node.IsLeaf)
            {
                if (node.YesNode != null)
                {
                    var yesNode = new TreeNode("✅ Да");
                    treeNode.Nodes.Add(yesNode);
                    BuildTreeViewNodes(node.YesNode, yesNode);
                }
                if (node.NoNode != null)
                {
                    var noNode = new TreeNode("❌ Нет");
                    treeNode.Nodes.Add(noNode);
                    BuildTreeViewNodes(node.NoNode, noNode);
                }
            }
        }

        private void ResetApplication()
        {
            _currentNode = _root;
            _history = new Stack<DecisionNode>();
            _answerHistory = new List<string>();

            lblQuestion.Text = _root.Question;
            lblResult.Text = string.Empty;
            lblResult.Visible = false;
            lstHistory.Items.Clear();

            HighlightCurrentNode();
            UpdateButtons();
        }

        private void HighlightCurrentNode()
        {
            treeViewDecision.SelectedNode = _currentNode.TreeViewItem;
            if (_currentNode.TreeViewItem != null)
            {
                _currentNode.TreeViewItem.EnsureVisible();
                treeViewDecision.Focus();
            }
        }

        private void UpdateButtons()
        {
            btnBack.Enabled = _history.Count > 0;
            btnReset.Enabled = true;
            btnYes.Enabled = !_currentNode.IsLeaf;
            btnNo.Enabled = !_currentNode.IsLeaf;
        }

        private void ProcessAnswer(bool isYes)
        {
            _history.Push(_currentNode);

            string answer = isYes ? "Да" : "Нет";
            string historyItem = $"[{DateTime.Now:HH:mm:ss}] {lblQuestion.Text}\n   ➤ Ответ: {answer}";
            _answerHistory.Add(historyItem);

            lstHistory.Items.Clear();
            lstHistory.Items.AddRange(_answerHistory.ToArray());
            lstHistory.TopIndex = lstHistory.Items.Count - 1;

            _currentNode = isYes ? _currentNode.YesNode : _currentNode.NoNode;

            if (_currentNode.IsLeaf)
            {
                lblQuestion.Text = "🎯 Результат анализа:";
                lblResult.Text = _currentNode.Result;
                lblResult.Visible = true;
                lblResult.ForeColor = Color.DarkGreen;
                lblResult.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            }
            else
            {
                lblQuestion.Text = _currentNode.Question;
                lblResult.Visible = false;
            }

            HighlightCurrentNode();
            UpdateButtons();
        }

        private void GoBack()
        {
            if (_history.Count == 0) return;

            if (_answerHistory.Count > 0)
                _answerHistory.RemoveAt(_answerHistory.Count - 1);

            _currentNode = _history.Pop();

            lblQuestion.Text = _currentNode.Question;
            lblResult.Visible = false;

            lstHistory.Items.Clear();
            if (_answerHistory.Count > 0)
                lstHistory.Items.AddRange(_answerHistory.ToArray());

            HighlightCurrentNode();
            UpdateButtons();
        }

        private void btnYes_Click(object sender, EventArgs e) => ProcessAnswer(true);
        private void btnNo_Click(object sender, EventArgs e) => ProcessAnswer(false);
        private void btnBack_Click(object sender, EventArgs e) => GoBack();

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Начать анализ заново?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ResetApplication();
            }
        }

        private void treeViewDecision_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (_currentNode.IsLeaf) return;
            HighlightCurrentNode();
        }
    }
}
