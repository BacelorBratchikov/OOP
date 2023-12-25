namespace WinFormsApp
{
    partial class AddRunningUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            labelDistance = new Label();
            labelSpeed = new Label();
            labelKm = new Label();
            labelKmPerH = new Label();
            textBoxDistance = new TextBox();
            textBoxSpeed = new TextBox();
            SuspendLayout();
            // 
            // labelDistance
            // 
            labelDistance.AutoSize = true;
            labelDistance.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelDistance.Location = new Point(16, 36);
            labelDistance.Name = "labelDistance";
            labelDistance.Size = new Size(95, 23);
            labelDistance.TabIndex = 0;
            labelDistance.Text = "Дистанция";
            // 
            // labelSpeed
            // 
            labelSpeed.AutoSize = true;
            labelSpeed.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelSpeed.Location = new Point(16, 72);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(83, 23);
            labelSpeed.TabIndex = 0;
            labelSpeed.Text = "Скорость";
            // 
            // labelKm
            // 
            labelKm.AutoSize = true;
            labelKm.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelKm.Location = new Point(259, 36);
            labelKm.Name = "labelKm";
            labelKm.Size = new Size(30, 23);
            labelKm.TabIndex = 0;
            labelKm.Text = "км";
            // 
            // labelKmPerH
            // 
            labelKmPerH.AutoSize = true;
            labelKmPerH.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelKmPerH.Location = new Point(259, 72);
            labelKmPerH.Name = "labelKmPerH";
            labelKmPerH.Size = new Size(46, 23);
            labelKmPerH.TabIndex = 0;
            labelKmPerH.Text = "км\\ч";
            // 
            // textBoxDistance
            // 
            textBoxDistance.Location = new Point(128, 32);
            textBoxDistance.Name = "textBoxDistance";
            textBoxDistance.Size = new Size(125, 27);
            textBoxDistance.TabIndex = 1;
            textBoxDistance.KeyPress += TextBoxCheckKeyPress;
            // 
            // textBoxSpeed
            // 
            textBoxSpeed.Location = new Point(128, 68);
            textBoxSpeed.Name = "textBoxSpeed";
            textBoxSpeed.Size = new Size(125, 27);
            textBoxSpeed.TabIndex = 1;
            textBoxSpeed.KeyPress += TextBoxCheckKeyPress;
            // 
            // AddRunningUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxSpeed);
            Controls.Add(textBoxDistance);
            Controls.Add(labelKmPerH);
            Controls.Add(labelKm);
            Controls.Add(labelSpeed);
            Controls.Add(labelDistance);
            Name = "AddRunningUserControl";
            Size = new Size(309, 122);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDistance;
        private Label labelSpeed;
        private Label labelKm;
        private Label labelKmPerH;
        private TextBox textBoxDistance;
        private TextBox textBoxSpeed;
    }
}
