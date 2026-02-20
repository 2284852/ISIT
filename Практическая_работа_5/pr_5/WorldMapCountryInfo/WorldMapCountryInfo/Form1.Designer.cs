namespace WorldMapCountryInfo
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
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblPopulationValue = new System.Windows.Forms.Label();
            this.lblCurrencyValue = new System.Windows.Forms.Label();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.pictureBoxFlag = new System.Windows.Forms.PictureBox();
            this.lblPopulation = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl
            // 
            this.gMapControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.Location = new System.Drawing.Point(0, 0);
            this.gMapControl.MarkersEnabled = true;
            this.gMapControl.MaxZoom = 18;
            this.gMapControl.MinZoom = 2;
            this.gMapControl.MouseWheelZoomEnabled = true;
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.Name = "gMapControl";
            this.gMapControl.NegativeMode = false;
            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.RetryLoadTile = 0;
            this.gMapControl.RoutesEnabled = true;
            this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl.ShowTileGridLines = false;
            this.gMapControl.Size = new System.Drawing.Size(600, 450);
            this.gMapControl.TabIndex = 0;
            this.gMapControl.Zoom = 2D;
            this.gMapControl.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMapControl_OnMarkerClick);
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelInfo.Controls.Add(this.lblPopulationValue);
            this.panelInfo.Controls.Add(this.lblCurrencyValue);
            this.panelInfo.Controls.Add(this.lblCountryName);
            this.panelInfo.Controls.Add(this.pictureBoxFlag);
            this.panelInfo.Controls.Add(this.lblPopulation);
            this.panelInfo.Controls.Add(this.lblCurrency);
            this.panelInfo.Location = new System.Drawing.Point(600, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(250, 450);
            this.panelInfo.TabIndex = 1;
            // 
            // lblPopulationValue
            // 
            this.lblPopulationValue.AutoSize = true;
            this.lblPopulationValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPopulationValue.Location = new System.Drawing.Point(15, 380);
            this.lblPopulationValue.Name = "lblPopulationValue";
            this.lblPopulationValue.Size = new System.Drawing.Size(0, 15);
            this.lblPopulationValue.TabIndex = 5;
            // 
            // lblCurrencyValue
            // 
            this.lblCurrencyValue.AutoSize = true;
            this.lblCurrencyValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCurrencyValue.Location = new System.Drawing.Point(15, 350);
            this.lblCurrencyValue.Name = "lblCurrencyValue";
            this.lblCurrencyValue.Size = new System.Drawing.Size(0, 15);
            this.lblCurrencyValue.TabIndex = 4;
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCountryName.Location = new System.Drawing.Point(15, 220);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(0, 21);
            this.lblCountryName.TabIndex = 3;
            // 
            // pictureBoxFlag
            // 
            this.pictureBoxFlag.Location = new System.Drawing.Point(15, 15);
            this.pictureBoxFlag.Name = "pictureBoxFlag";
            this.pictureBoxFlag.Size = new System.Drawing.Size(220, 150);
            this.pictureBoxFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFlag.TabIndex = 2;
            this.pictureBoxFlag.TabStop = false;
            // 
            // lblPopulation
            // 
            this.lblPopulation.AutoSize = true;
            this.lblPopulation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPopulation.Location = new System.Drawing.Point(15, 365);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(86, 15);
            this.lblPopulation.TabIndex = 1;
            this.lblPopulation.Text = "Население:";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCurrency.Location = new System.Drawing.Point(15, 335);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(63, 15);
            this.lblCurrency.TabIndex = 0;
            this.lblCurrency.Text = "Валюта:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.gMapControl);
            this.Name = "Form1";
            this.Text = "Интерактивная карта мира";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).EndInit();
            this.ResumeLayout(false);
        }

        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.PictureBox pictureBoxFlag;
        private System.Windows.Forms.Label lblPopulation;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.Label lblCurrencyValue;
        private System.Windows.Forms.Label lblPopulationValue;
    }
}

