namespace WeatherExpertSystem
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
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.btnGetWeather = new System.Windows.Forms.Button();
            this.panelCard = new System.Windows.Forms.Panel();
            this.lblHumidityAssessmentValue = new System.Windows.Forms.Label();
            this.lblPrecipitationAssessmentValue = new System.Windows.Forms.Label();
            this.lblWindAssessmentValue = new System.Windows.Forms.Label();
            this.lblTempAssessmentValue = new System.Windows.Forms.Label();
            this.lblStateValue = new System.Windows.Forms.Label();
            this.lblPrecipitationValue = new System.Windows.Forms.Label();
            this.lblPressureValue = new System.Windows.Forms.Label();
            this.lblWindValue = new System.Windows.Forms.Label();
            this.lblHumidityValue = new System.Windows.Forms.Label();
            this.lblFeelsLikeValue = new System.Windows.Forms.Label();
            this.lblTempValue = new System.Windows.Forms.Label();
            this.lblCityValue = new System.Windows.Forms.Label();
            this.lblHumidityAssessmentTitle = new System.Windows.Forms.Label();
            this.lblPrecipitationAssessmentTitle = new System.Windows.Forms.Label();
            this.lblWindAssessmentTitle = new System.Windows.Forms.Label();
            this.lblTempAssessmentTitle = new System.Windows.Forms.Label();
            this.lblStateTitle = new System.Windows.Forms.Label();
            this.lblPrecipitationTitle = new System.Windows.Forms.Label();
            this.lblPressureTitle = new System.Windows.Forms.Label();
            this.lblWindTitle = new System.Windows.Forms.Label();
            this.lblHumidityTitle = new System.Windows.Forms.Label();
            this.lblFeelsLikeTitle = new System.Windows.Forms.Label();
            this.lblTempTitle = new System.Windows.Forms.Label();
            this.lblCityTitle = new System.Windows.Forms.Label();
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCity
            // 
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(20, 20);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(220, 25);
            this.cmbCity.TabIndex = 0;
            // 
            // btnGetWeather
            // 
            this.btnGetWeather.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGetWeather.FlatAppearance.BorderSize = 0;
            this.btnGetWeather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetWeather.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetWeather.ForeColor = System.Drawing.Color.White;
            this.btnGetWeather.Location = new System.Drawing.Point(250, 19);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(140, 27);
            this.btnGetWeather.TabIndex = 1;
            this.btnGetWeather.Text = "Получить прогноз";
            this.btnGetWeather.UseVisualStyleBackColor = false;
            this.btnGetWeather.Click += new System.EventHandler(this.btnGetWeather_Click);
            // 
            // panelCard
            // 
            this.panelCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.lblHumidityAssessmentValue);
            this.panelCard.Controls.Add(this.lblPrecipitationAssessmentValue);
            this.panelCard.Controls.Add(this.lblWindAssessmentValue);
            this.panelCard.Controls.Add(this.lblTempAssessmentValue);
            this.panelCard.Controls.Add(this.lblStateValue);
            this.panelCard.Controls.Add(this.lblPrecipitationValue);
            this.panelCard.Controls.Add(this.lblPressureValue);
            this.panelCard.Controls.Add(this.lblWindValue);
            this.panelCard.Controls.Add(this.lblHumidityValue);
            this.panelCard.Controls.Add(this.lblFeelsLikeValue);
            this.panelCard.Controls.Add(this.lblTempValue);
            this.panelCard.Controls.Add(this.lblCityValue);
            this.panelCard.Controls.Add(this.lblHumidityAssessmentTitle);
            this.panelCard.Controls.Add(this.lblPrecipitationAssessmentTitle);
            this.panelCard.Controls.Add(this.lblWindAssessmentTitle);
            this.panelCard.Controls.Add(this.lblTempAssessmentTitle);
            this.panelCard.Controls.Add(this.lblStateTitle);
            this.panelCard.Controls.Add(this.lblPrecipitationTitle);
            this.panelCard.Controls.Add(this.lblPressureTitle);
            this.panelCard.Controls.Add(this.lblWindTitle);
            this.panelCard.Controls.Add(this.lblHumidityTitle);
            this.panelCard.Controls.Add(this.lblFeelsLikeTitle);
            this.panelCard.Controls.Add(this.lblTempTitle);
            this.panelCard.Controls.Add(this.lblCityTitle);
            this.panelCard.Location = new System.Drawing.Point(20, 60);
            this.panelCard.Name = "panelCard";
            this.panelCard.Padding = new System.Windows.Forms.Padding(15);
            this.panelCard.Size = new System.Drawing.Size(560, 380);
            this.panelCard.TabIndex = 2;
            // 
            // lblHumidityAssessmentValue
            // 
            this.lblHumidityAssessmentValue.AutoSize = true;
            this.lblHumidityAssessmentValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHumidityAssessmentValue.Location = new System.Drawing.Point(170, 345);
            this.lblHumidityAssessmentValue.Name = "lblHumidityAssessmentValue";
            this.lblHumidityAssessmentValue.Size = new System.Drawing.Size(0, 19);
            this.lblHumidityAssessmentValue.TabIndex = 23;
            // 
            // lblPrecipitationAssessmentValue
            // 
            this.lblPrecipitationAssessmentValue.AutoSize = true;
            this.lblPrecipitationAssessmentValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrecipitationAssessmentValue.Location = new System.Drawing.Point(170, 315);
            this.lblPrecipitationAssessmentValue.Name = "lblPrecipitationAssessmentValue";
            this.lblPrecipitationAssessmentValue.Size = new System.Drawing.Size(0, 19);
            this.lblPrecipitationAssessmentValue.TabIndex = 22;
            // 
            // lblWindAssessmentValue
            // 
            this.lblWindAssessmentValue.AutoSize = true;
            this.lblWindAssessmentValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblWindAssessmentValue.Location = new System.Drawing.Point(170, 285);
            this.lblWindAssessmentValue.Name = "lblWindAssessmentValue";
            this.lblWindAssessmentValue.Size = new System.Drawing.Size(0, 19);
            this.lblWindAssessmentValue.TabIndex = 21;
            // 
            // lblTempAssessmentValue
            // 
            this.lblTempAssessmentValue.AutoSize = true;
            this.lblTempAssessmentValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTempAssessmentValue.Location = new System.Drawing.Point(170, 255);
            this.lblTempAssessmentValue.Name = "lblTempAssessmentValue";
            this.lblTempAssessmentValue.Size = new System.Drawing.Size(0, 19);
            this.lblTempAssessmentValue.TabIndex = 20;
            // 
            // lblStateValue
            // 
            this.lblStateValue.AutoSize = true;
            this.lblStateValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStateValue.Location = new System.Drawing.Point(170, 225);
            this.lblStateValue.Name = "lblStateValue";
            this.lblStateValue.Size = new System.Drawing.Size(0, 19);
            this.lblStateValue.TabIndex = 19;
            // 
            // lblPrecipitationValue
            // 
            this.lblPrecipitationValue.AutoSize = true;
            this.lblPrecipitationValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPrecipitationValue.Location = new System.Drawing.Point(170, 195);
            this.lblPrecipitationValue.Name = "lblPrecipitationValue";
            this.lblPrecipitationValue.Size = new System.Drawing.Size(0, 19);
            this.lblPrecipitationValue.TabIndex = 18;
            // 
            // lblPressureValue
            // 
            this.lblPressureValue.AutoSize = true;
            this.lblPressureValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPressureValue.Location = new System.Drawing.Point(170, 165);
            this.lblPressureValue.Name = "lblPressureValue";
            this.lblPressureValue.Size = new System.Drawing.Size(0, 19);
            this.lblPressureValue.TabIndex = 17;
            // 
            // lblWindValue
            // 
            this.lblWindValue.AutoSize = true;
            this.lblWindValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWindValue.Location = new System.Drawing.Point(170, 135);
            this.lblWindValue.Name = "lblWindValue";
            this.lblWindValue.Size = new System.Drawing.Size(0, 19);
            this.lblWindValue.TabIndex = 16;
            // 
            // lblHumidityValue
            // 
            this.lblHumidityValue.AutoSize = true;
            this.lblHumidityValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHumidityValue.Location = new System.Drawing.Point(170, 105);
            this.lblHumidityValue.Name = "lblHumidityValue";
            this.lblHumidityValue.Size = new System.Drawing.Size(0, 19);
            this.lblHumidityValue.TabIndex = 15;
            // 
            // lblFeelsLikeValue
            // 
            this.lblFeelsLikeValue.AutoSize = true;
            this.lblFeelsLikeValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFeelsLikeValue.Location = new System.Drawing.Point(170, 75);
            this.lblFeelsLikeValue.Name = "lblFeelsLikeValue";
            this.lblFeelsLikeValue.Size = new System.Drawing.Size(0, 19);
            this.lblFeelsLikeValue.TabIndex = 14;
            // 
            // lblTempValue
            // 
            this.lblTempValue.AutoSize = true;
            this.lblTempValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTempValue.Location = new System.Drawing.Point(170, 45);
            this.lblTempValue.Name = "lblTempValue";
            this.lblTempValue.Size = new System.Drawing.Size(0, 19);
            this.lblTempValue.TabIndex = 13;
            // 
            // lblCityValue
            // 
            this.lblCityValue.AutoSize = true;
            this.lblCityValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCityValue.Location = new System.Drawing.Point(170, 15);
            this.lblCityValue.Name = "lblCityValue";
            this.lblCityValue.Size = new System.Drawing.Size(0, 19);
            this.lblCityValue.TabIndex = 12;
            // 
            // lblHumidityAssessmentTitle
            // 
            this.lblHumidityAssessmentTitle.AutoSize = true;
            this.lblHumidityAssessmentTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHumidityAssessmentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHumidityAssessmentTitle.Location = new System.Drawing.Point(15, 345);
            this.lblHumidityAssessmentTitle.Name = "lblHumidityAssessmentTitle";
            this.lblHumidityAssessmentTitle.Size = new System.Drawing.Size(146, 19);
            this.lblHumidityAssessmentTitle.TabIndex = 11;
            this.lblHumidityAssessmentTitle.Text = "Оценка влажности:";
            // 
            // lblPrecipitationAssessmentTitle
            // 
            this.lblPrecipitationAssessmentTitle.AutoSize = true;
            this.lblPrecipitationAssessmentTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrecipitationAssessmentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrecipitationAssessmentTitle.Location = new System.Drawing.Point(15, 315);
            this.lblPrecipitationAssessmentTitle.Name = "lblPrecipitationAssessmentTitle";
            this.lblPrecipitationAssessmentTitle.Size = new System.Drawing.Size(128, 19);
            this.lblPrecipitationAssessmentTitle.TabIndex = 10;
            this.lblPrecipitationAssessmentTitle.Text = "Оценка осадков:";
            // 
            // lblWindAssessmentTitle
            // 
            this.lblWindAssessmentTitle.AutoSize = true;
            this.lblWindAssessmentTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblWindAssessmentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblWindAssessmentTitle.Location = new System.Drawing.Point(15, 285);
            this.lblWindAssessmentTitle.Name = "lblWindAssessmentTitle";
            this.lblWindAssessmentTitle.Size = new System.Drawing.Size(109, 19);
            this.lblWindAssessmentTitle.TabIndex = 9;
            this.lblWindAssessmentTitle.Text = "Оценка ветра:";
            // 
            // lblTempAssessmentTitle
            // 
            this.lblTempAssessmentTitle.AutoSize = true;
            this.lblTempAssessmentTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTempAssessmentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTempAssessmentTitle.Location = new System.Drawing.Point(15, 255);
            this.lblTempAssessmentTitle.Name = "lblTempAssessmentTitle";
            this.lblTempAssessmentTitle.Size = new System.Drawing.Size(163, 19);
            this.lblTempAssessmentTitle.TabIndex = 8;
            this.lblTempAssessmentTitle.Text = "Оценка температуры:";
            // 
            // lblStateTitle
            // 
            this.lblStateTitle.AutoSize = true;
            this.lblStateTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStateTitle.Location = new System.Drawing.Point(15, 225);
            this.lblStateTitle.Name = "lblStateTitle";
            this.lblStateTitle.Size = new System.Drawing.Size(87, 19);
            this.lblStateTitle.TabIndex = 7;
            this.lblStateTitle.Text = "Состояние:";
            // 
            // lblPrecipitationTitle
            // 
            this.lblPrecipitationTitle.AutoSize = true;
            this.lblPrecipitationTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrecipitationTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrecipitationTitle.Location = new System.Drawing.Point(15, 195);
            this.lblPrecipitationTitle.Name = "lblPrecipitationTitle";
            this.lblPrecipitationTitle.Size = new System.Drawing.Size(89, 19);
            this.lblPrecipitationTitle.TabIndex = 6;
            this.lblPrecipitationTitle.Text = "☔ Осадки:";
            // 
            // lblPressureTitle
            // 
            this.lblPressureTitle.AutoSize = true;
            this.lblPressureTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPressureTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPressureTitle.Location = new System.Drawing.Point(15, 165);
            this.lblPressureTitle.Name = "lblPressureTitle";
            this.lblPressureTitle.Size = new System.Drawing.Size(106, 19);
            this.lblPressureTitle.TabIndex = 5;
            this.lblPressureTitle.Text = "📉 Давление:";
            // 
            // lblWindTitle
            // 
            this.lblWindTitle.AutoSize = true;
            this.lblWindTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblWindTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblWindTitle.Location = new System.Drawing.Point(15, 135);
            this.lblWindTitle.Name = "lblWindTitle";
            this.lblWindTitle.Size = new System.Drawing.Size(77, 19);
            this.lblWindTitle.TabIndex = 4;
            this.lblWindTitle.Text = "🌬️ Ветер:";
            // 
            // lblHumidityTitle
            // 
            this.lblHumidityTitle.AutoSize = true;
            this.lblHumidityTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHumidityTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHumidityTitle.Location = new System.Drawing.Point(15, 105);
            this.lblHumidityTitle.Name = "lblHumidityTitle";
            this.lblHumidityTitle.Size = new System.Drawing.Size(113, 19);
            this.lblHumidityTitle.TabIndex = 3;
            this.lblHumidityTitle.Text = "💧 Влажность:";
            // 
            // lblFeelsLikeTitle
            // 
            this.lblFeelsLikeTitle.AutoSize = true;
            this.lblFeelsLikeTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFeelsLikeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFeelsLikeTitle.Location = new System.Drawing.Point(15, 75);
            this.lblFeelsLikeTitle.Name = "lblFeelsLikeTitle";
            this.lblFeelsLikeTitle.Size = new System.Drawing.Size(123, 19);
            this.lblFeelsLikeTitle.TabIndex = 2;
            this.lblFeelsLikeTitle.Text = "Ощущается как:";
            // 
            // lblTempTitle
            // 
            this.lblTempTitle.AutoSize = true;
            this.lblTempTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTempTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTempTitle.Location = new System.Drawing.Point(15, 45);
            this.lblTempTitle.Name = "lblTempTitle";
            this.lblTempTitle.Size = new System.Drawing.Size(128, 19);
            this.lblTempTitle.TabIndex = 1;
            this.lblTempTitle.Text = "🌡️ Температура:";
            // 
            // lblCityTitle
            // 
            this.lblCityTitle.AutoSize = true;
            this.lblCityTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCityTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCityTitle.Location = new System.Drawing.Point(15, 15);
            this.lblCityTitle.Name = "lblCityTitle";
            this.lblCityTitle.Size = new System.Drawing.Size(55, 19);
            this.lblCityTitle.TabIndex = 0;
            this.lblCityTitle.Text = "Город:";
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLastUpdated.AutoSize = true;
            this.lblLastUpdated.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblLastUpdated.ForeColor = System.Drawing.Color.Gray;
            this.lblLastUpdated.Location = new System.Drawing.Point(20, 450);
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(0, 15);
            this.lblLastUpdated.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(600, 480);
            this.Controls.Add(this.lblLastUpdated);
            this.Controls.Add(this.panelCard);
            this.Controls.Add(this.btnGetWeather);
            this.Controls.Add(this.cmbCity);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(616, 519);
            this.Name = "Form1";
            this.Text = "Экспертная система погоды";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Button btnGetWeather;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label lblCityTitle;
        private System.Windows.Forms.Label lblTempTitle;
        private System.Windows.Forms.Label lblFeelsLikeTitle;
        private System.Windows.Forms.Label lblHumidityTitle;
        private System.Windows.Forms.Label lblWindTitle;
        private System.Windows.Forms.Label lblPressureTitle;
        private System.Windows.Forms.Label lblPrecipitationTitle;
        private System.Windows.Forms.Label lblStateTitle;
        private System.Windows.Forms.Label lblTempAssessmentTitle;
        private System.Windows.Forms.Label lblWindAssessmentTitle;
        private System.Windows.Forms.Label lblPrecipitationAssessmentTitle;
        private System.Windows.Forms.Label lblHumidityAssessmentTitle;
        private System.Windows.Forms.Label lblCityValue;
        private System.Windows.Forms.Label lblTempValue;
        private System.Windows.Forms.Label lblFeelsLikeValue;
        private System.Windows.Forms.Label lblHumidityValue;
        private System.Windows.Forms.Label lblWindValue;
        private System.Windows.Forms.Label lblPressureValue;
        private System.Windows.Forms.Label lblPrecipitationValue;
        private System.Windows.Forms.Label lblStateValue;
        private System.Windows.Forms.Label lblTempAssessmentValue;
        private System.Windows.Forms.Label lblWindAssessmentValue;
        private System.Windows.Forms.Label lblPrecipitationAssessmentValue;
        private System.Windows.Forms.Label lblHumidityAssessmentValue;
        private System.Windows.Forms.Label lblLastUpdated;
    }
}

