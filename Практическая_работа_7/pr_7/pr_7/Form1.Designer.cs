namespace pr_7
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
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.btnAddRoad = new System.Windows.Forms.Button();
            this.btnFindPath = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblInstruction = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlControls.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // pnlGraph
            this.pnlGraph.BackColor = System.Drawing.Color.White;
            this.pnlGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGraph.Location = new System.Drawing.Point(0, 0);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(884, 411);
            this.pnlGraph.TabIndex = 0;
            this.pnlGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGraph_Paint);
            this.pnlGraph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlGraph_MouseDown);
            this.pnlGraph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlGraph_MouseMove);
            this.pnlGraph.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlGraph_MouseUp);

            // pnlControls
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.pnlControls.Controls.Add(this.btnClear);
            this.pnlControls.Controls.Add(this.btnFindPath);
            this.pnlControls.Controls.Add(this.btnAddRoad);
            this.pnlControls.Controls.Add(this.btnAddCity);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControls.Location = new System.Drawing.Point(884, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(184, 411);
            this.pnlControls.TabIndex = 1;

            // btnAddCity
            this.btnAddCity.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnAddCity.FlatAppearance.BorderSize = 0;
            this.btnAddCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddCity.ForeColor = System.Drawing.Color.White;
            this.btnAddCity.Location = new System.Drawing.Point(12, 20);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(160, 40);
            this.btnAddCity.TabIndex = 0;
            this.btnAddCity.Text = "🏙 Добавить город";
            this.btnAddCity.UseVisualStyleBackColor = false;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);

            // btnAddRoad
            this.btnAddRoad.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnAddRoad.FlatAppearance.BorderSize = 0;
            this.btnAddRoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddRoad.ForeColor = System.Drawing.Color.White;
            this.btnAddRoad.Location = new System.Drawing.Point(12, 70);
            this.btnAddRoad.Name = "btnAddRoad";
            this.btnAddRoad.Size = new System.Drawing.Size(160, 40);
            this.btnAddRoad.TabIndex = 1;
            this.btnAddRoad.Text = "🛣 Создать дорогу";
            this.btnAddRoad.UseVisualStyleBackColor = false;
            this.btnAddRoad.Click += new System.EventHandler(this.btnAddRoad_Click);

            // btnFindPath
            this.btnFindPath.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.btnFindPath.FlatAppearance.BorderSize = 0;
            this.btnFindPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFindPath.ForeColor = System.Drawing.Color.White;
            this.btnFindPath.Location = new System.Drawing.Point(12, 120);
            this.btnFindPath.Name = "btnFindPath";
            this.btnFindPath.Size = new System.Drawing.Size(160, 40);
            this.btnFindPath.TabIndex = 2;
            this.btnFindPath.Text = "📊 Инфо о графе";
            this.btnFindPath.UseVisualStyleBackColor = false;
            this.btnFindPath.Click += new System.EventHandler(this.btnFindPath_Click);

            // btnClear
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(12, 170);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 40);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "🗑 Очистить всё";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // statusStrip1
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblInfo,
            this.lblInstruction});
            this.statusStrip1.Location = new System.Drawing.Point(0, 411);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1068, 22);
            this.statusStrip1.TabIndex = 2;

            // lblStatus
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 17);
            this.lblStatus.Text = "Вершин: 0 | Рёбер: 0";

            // lblInfo
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(400, 17);
            this.lblInfo.Spring = true;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInfo.Text = "Информация: -";

            // lblInstruction
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(100, 17);
            this.lblInstruction.Text = "Режим: Выбор";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 433);
            this.Controls.Add(this.pnlGraph);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🗺 Транспортная сеть городов - Граф";
            this.pnlControls.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.Button btnAddRoad;
        private System.Windows.Forms.Button btnFindPath;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblInfo;
        private System.Windows.Forms.ToolStripStatusLabel lblInstruction;
    }
}

