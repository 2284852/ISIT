using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace pr_7
{
    public partial class Form1 : Form
    {
        private List<Vertex> vertices;
        private List<Edge> edges;
        private int nextVertexId;
        private int nextEdgeId;
        private Vertex selectedVertex;
        private Edge selectedEdge;
        private Vertex draggedVertex;
        private Vertex tempVertex;
        private bool isCreatingEdge;
        private ContextMenu contextMenu;

        public Form1()
        {
            InitializeComponent();
            InitializeGraph();
            SetupContextMenu();
            AddSampleData();
        }
        private void InitializeGraph()
        {
            vertices = new List<Vertex>();
            edges = new List<Edge>();
            nextVertexId = 1;
            nextEdgeId = 1;
            isCreatingEdge = false;
        }

        private void SetupContextMenu()
        {
            contextMenu = new ContextMenu();
            MenuItem miDelete = new MenuItem("Удалить", (s, e) => DeleteSelectedObject());
            MenuItem miEditDistance = new MenuItem("Изменить расстояние", (s, e) => EditEdgeDistance());
            MenuItem miClear = new MenuItem("Очистить всё", (s, e) => ClearGraph());

            contextMenu.MenuItems.Add(miDelete);
            contextMenu.MenuItems.Add(miEditDistance);
            contextMenu.MenuItems.Add("-");
            contextMenu.MenuItems.Add(miClear);
        }

        private void AddSampleData()
        {
            var moscow = new Vertex(nextVertexId++, "Москва", new Point(300, 250));
            var spb = new Vertex(nextVertexId++, "СПб", new Point(280, 100));
            var kazan = new Vertex(nextVertexId++, "Казань", new Point(450, 280));
            var sochi = new Vertex(nextVertexId++, "Сочи", new Point(350, 450));
            var ekb = new Vertex(nextVertexId++, "Екатеринбург", new Point(600, 200));

            vertices.AddRange(new[] { moscow, spb, kazan, sochi, ekb });

            edges.Add(new Edge(nextEdgeId++, moscow, spb, 700));
            edges.Add(new Edge(nextEdgeId++, moscow, kazan, 800));
            edges.Add(new Edge(nextEdgeId++, moscow, sochi, 1600));
            edges.Add(new Edge(nextEdgeId++, moscow, ekb, 1800));
            edges.Add(new Edge(nextEdgeId++, kazan, ekb, 1000));

            pnlGraph.Invalidate();
            UpdateStatus();
        }

        private void pnlGraph_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            foreach (var edge in edges)
                edge.Draw(e.Graphics);

            foreach (var vertex in vertices)
                vertex.Draw(e.Graphics);

            if (isCreatingEdge && tempVertex != null)
            {
                Point mousePos = pnlGraph.PointToClient(Control.MousePosition);
                using (Pen pen = new Pen(Color.Green, 2))
                {
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    e.Graphics.DrawLine(pen, tempVertex.Location, mousePos);
                }
            }
        }

        private void pnlGraph_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Vertex clickedVertex = null;
                foreach (var v in vertices)
                {
                    if (v.Contains(e.Location))
                    {
                        clickedVertex = v;
                        break;
                    }
                }

                if (clickedVertex != null)
                {
                    if (isCreatingEdge)
                    {
                        if (tempVertex == null)
                        {
                            tempVertex = clickedVertex;
                            lblInstruction.Text = $"Выберите второй город (выбран: {tempVertex.Name})";
                        }
                        else if (tempVertex != clickedVertex)
                        {
                            CreateEdge(tempVertex, clickedVertex);
                            isCreatingEdge = false;
                            tempVertex = null;
                            lblInstruction.Text = "Режим: Выбор";
                        }
                    }
                    else
                    {
                        SelectVertex(clickedVertex);
                        draggedVertex = clickedVertex;
                    }
                }
                else
                {
                    Edge clickedEdge = null;
                    foreach (var edge in edges)
                    {
                        if (edge.Contains(e.Location))
                        {
                            clickedEdge = edge;
                            break;
                        }
                    }

                    if (clickedEdge != null)
                    {
                        SelectEdge(clickedEdge);
                    }
                    else
                    {
                        ClearSelection();
                    }
                }
                pnlGraph.Invalidate();
            }
            else if (e.Button == MouseButtons.Right)
            {
                contextMenu.Show(pnlGraph, e.Location);
            }
        }

        private void pnlGraph_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggedVertex != null && e.Button == MouseButtons.Left)
            {
                draggedVertex.Location = e.Location;
                pnlGraph.Invalidate();
            }
        }

        private void pnlGraph_MouseUp(object sender, MouseEventArgs e)
        {
            draggedVertex = null;
        }

        private void CreateEdge(Vertex from, Vertex to)
        {
            bool exists = false;
            foreach (var e in edges)
            {
                if ((e.From == from && e.To == to) || (e.From == to && e.To == from))
                {
                    exists = true;
                    break;
                }
            }

            if (!exists)
            {
                using (var dialog = new InputDialog("Новое ребро", "Введите расстояние (км):", "100"))
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        string input = dialog.InputValue;
                        if (!string.IsNullOrEmpty(input))
                        {
                            input = input.Trim();
                            int distance;
                            if (int.TryParse(input, out distance) && distance > 0)
                            {
                                edges.Add(new Edge(nextEdgeId++, from, to, distance));
                                pnlGraph.Invalidate();
                                UpdateStatus();
                            }
                            else
                            {
                                MessageBox.Show("Введите положительное число!", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Такое ребро уже существует!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SelectVertex(Vertex vertex)
        {
            ClearSelection();
            selectedVertex = vertex;
            vertex.IsSelected = true;
            lblInfo.Text = $"Вершина: {vertex.Name}";
        }

        private void SelectEdge(Edge edge)
        {
            ClearSelection();
            selectedEdge = edge;
            edge.IsSelected = true;
            lblInfo.Text = $"Ребро: {edge.From.Name} - {edge.To.Name} ({edge.Distance} км)";
        }

        private void ClearSelection()
        {
            if (selectedVertex != null)
            {
                selectedVertex.IsSelected = false;
                selectedVertex = null;
            }
            if (selectedEdge != null)
            {
                selectedEdge.IsSelected = false;
                selectedEdge = null;
            }
        }

        private void DeleteSelectedObject()
        {
            if (selectedVertex != null)
            {
                for (int i = edges.Count - 1; i >= 0; i--)
                {
                    if (edges[i].From == selectedVertex || edges[i].To == selectedVertex)
                    {
                        edges.RemoveAt(i);
                    }
                }
                vertices.Remove(selectedVertex);
                selectedVertex = null;
            }
            else if (selectedEdge != null)
            {
                edges.Remove(selectedEdge);
                selectedEdge = null;
            }

            pnlGraph.Invalidate();
            UpdateStatus();
        }

        private void EditEdgeDistance()
        {
            if (selectedEdge != null)
            {
                using (var dialog = new InputDialog("Редактирование",
                    "Введите новое расстояние (км):", selectedEdge.Distance.ToString()))
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        string input = dialog.InputValue;
                        if (!string.IsNullOrEmpty(input))
                        {
                            input = input.Trim();
                            int distance;
                            if (int.TryParse(input, out distance) && distance > 0)
                            {
                                selectedEdge.Distance = distance;
                                pnlGraph.Invalidate();
                                UpdateStatus();
                            }
                            else
                            {
                                MessageBox.Show("Введите положительное число!", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
        }

        private void ClearGraph()
        {
            if (MessageBox.Show("Очистить весь граф?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                InitializeGraph();
                pnlGraph.Invalidate();
                UpdateStatus();
            }
        }

        private void UpdateStatus()
        {
            lblStatus.Text = $"Вершин: {vertices.Count} | Рёбер: {edges.Count}";
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            using (var dialog = new InputDialog("Новый город", "Введите название города:", $"Город {nextVertexId}"))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string name = dialog.InputValue;
                    if (!string.IsNullOrEmpty(name))
                    {
                        name = name.Trim();
                        if (!string.IsNullOrEmpty(name))
                        {
                            int x = pnlGraph.Width / 2;
                            int y = pnlGraph.Height / 2;
                            if (x < 50) x = 200;
                            if (y < 50) y = 200;

                            Point center = new Point(x, y);
                            vertices.Add(new Vertex(nextVertexId++, name, center));
                            pnlGraph.Invalidate();
                            UpdateStatus();
                        }
                    }
                }
            }
        }

        private void btnAddRoad_Click(object sender, EventArgs e)
        {
            if (vertices.Count < 2)
            {
                MessageBox.Show("Добавьте минимум 2 города!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isCreatingEdge = true;
            tempVertex = null;
            lblInstruction.Text = "Кликните на ПЕРВЫЙ город";
            MessageBox.Show("Кликните на первый город, затем на второй",
                "Создание дороги", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFindPath_Click(object sender, EventArgs e)
        {
            int totalDistance = 0;
            foreach (var edge in edges)
            {
                totalDistance += edge.Distance;
                edge.IsSelected = true;
            }
            pnlGraph.Invalidate();

            MessageBox.Show($"Всего дорог: {edges.Count}\n" +
                          $"Всего городов: {vertices.Count}\n" +
                          $"Общая длина: {totalDistance} км",
                          "Информация о графе",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearGraph();
        }
    }
}
