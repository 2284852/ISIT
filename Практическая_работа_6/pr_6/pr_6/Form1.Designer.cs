namespace pr_6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.treeViewDecision = new System.Windows.Forms.TreeView();
            this.flowLayoutPanelRight = new System.Windows.Forms.FlowLayoutPanel();
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.panelResult = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.panelHistory = new System.Windows.Forms.Panel();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.flowLayoutPanelRight.SuspendLayout();
            this.panelQuestion.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.panelHistory.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();

            // SplitContainer - основная разметка
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Size = new System.Drawing.Size(1000, 650);
            this.splitContainerMain.SplitterDistance = 350;
            this.splitContainerMain.TabIndex = 0;

            // ЛЕВАЯ ПАНЕЛЬ - TreeView
            this.splitContainerMain.Panel1.Controls.Add(this.treeViewDecision);
            this.splitContainerMain.Panel1MinSize = 300;

            this.treeViewDecision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewDecision.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.treeViewDecision.Indent = 20;
            this.treeViewDecision.ItemHeight = 25;
            this.treeViewDecision.Location = new System.Drawing.Point(0, 0);
            this.treeViewDecision.Name = "treeViewDecision";
            this.treeViewDecision.ShowLines = true;
            this.treeViewDecision.ShowPlusMinus = true;
            this.treeViewDecision.ShowRootLines = true;
            this.treeViewDecision.Size = new System.Drawing.Size(350, 650);
            this.treeViewDecision.TabIndex = 0;
            this.treeViewDecision.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewDecision_AfterSelect);

            // ПРАВАЯ ПАНЕЛЬ - FlowLayoutPanel
            this.splitContainerMain.Panel2.Controls.Add(this.flowLayoutPanelRight);
            this.splitContainerMain.Panel2MinSize = 400;

            this.flowLayoutPanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelRight.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelRight.WrapContents = false;
            this.flowLayoutPanelRight.AutoScroll = true;
            this.flowLayoutPanelRight.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelRight.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelRight.Name = "flowLayoutPanelRight";
            this.flowLayoutPanelRight.Size = new System.Drawing.Size(646, 650);
            this.flowLayoutPanelRight.TabIndex = 0;

            // ПАНЕЛЬ ВОПРОСА
            this.panelQuestion.AutoSize = true;
            this.panelQuestion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelQuestion.Controls.Add(this.lblQuestion);
            this.panelQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuestion.Location = new System.Drawing.Point(0, 0);
            this.panelQuestion.MinimumSize = new System.Drawing.Size(0, 100);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Padding = new System.Windows.Forms.Padding(20);
            this.panelQuestion.Size = new System.Drawing.Size(629, 100);
            this.panelQuestion.TabIndex = 0;

            this.lblQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(0, 51, 102);
            this.lblQuestion.Location = new System.Drawing.Point(20, 20);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(589, 60);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Загрузка вопроса...";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ПАНЕЛЬ РЕЗУЛЬТАТА
            this.panelResult.AutoSize = true;
            this.panelResult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelResult.Controls.Add(this.lblResult);
            this.panelResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelResult.Location = new System.Drawing.Point(0, 100);
            this.panelResult.Name = "panelResult";
            this.panelResult.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.panelResult.Size = new System.Drawing.Size(629, 90);
            this.panelResult.TabIndex = 1;
            this.panelResult.Visible = false;

            this.lblResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblResult.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblResult.Location = new System.Drawing.Point(20, 10);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(589, 60);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Результат будет здесь";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // ПАНЕЛЬ ИСТОРИИ
            this.panelHistory.AutoSize = true;
            this.panelHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelHistory.Controls.Add(this.lstHistory);
            this.panelHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHistory.Location = new System.Drawing.Point(0, 190);
            this.panelHistory.MinimumSize = new System.Drawing.Size(0, 150);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelHistory.Size = new System.Drawing.Size(629, 165);
            this.panelHistory.TabIndex = 2;

            this.lstHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstHistory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.ItemHeight = 15;
            this.lstHistory.HorizontalScrollbar = true;
            this.lstHistory.Location = new System.Drawing.Point(20, 15);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(589, 135);
            this.lstHistory.TabIndex = 0;

            // ПАНЕЛЬ КНОПОК
            this.panelButtons.AutoSize = true;
            this.panelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelButtons.Controls.Add(this.btnReset);
            this.panelButtons.Controls.Add(this.btnBack);
            this.panelButtons.Controls.Add(this.btnNo);
            this.panelButtons.Controls.Add(this.btnYes);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 355);
            this.panelButtons.MinimumSize = new System.Drawing.Size(0, 80);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(20, 25, 20, 25);
            this.panelButtons.Size = new System.Drawing.Size(629, 80);
            this.panelButtons.TabIndex = 3;

            // Кнопка YES
            this.btnYes.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnYes.FlatAppearance.BorderSize = 0;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.Location = new System.Drawing.Point(420, 30);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(90, 40);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "✅ Да";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);

            // Кнопка NO
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(520, 30);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(90, 40);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "❌ Нет";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);

            // Кнопка BACK
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(142, 142, 142);
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(310, 30);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 40);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "⬅ Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // Кнопка RESET
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(200, 30);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 40);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "🔄 Сброс";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // Добавление панелей в FlowLayoutPanel
            this.flowLayoutPanelRight.Controls.Add(this.panelQuestion);
            this.flowLayoutPanelRight.Controls.Add(this.panelResult);
            this.flowLayoutPanelRight.Controls.Add(this.panelHistory);
            this.flowLayoutPanelRight.Controls.Add(this.panelButtons);

            // НАСТРОЙКИ ФОРМЫ
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.splitContainerMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1020, 690);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🌳 Дерево решений: Запуск продукта";

            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.ResumeLayout(false);
            this.flowLayoutPanelRight.ResumeLayout(false);
            this.flowLayoutPanelRight.PerformLayout();
            this.panelQuestion.ResumeLayout(false);
            this.panelResult.ResumeLayout(false);
            this.panelHistory.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
        }

        // Элементы управления
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TreeView treeViewDecision;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRight;
        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panelHistory;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReset;
    }
}

