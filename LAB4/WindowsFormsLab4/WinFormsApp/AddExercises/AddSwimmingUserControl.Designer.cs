namespace WinFormsApp
{
    partial class AddSwimmingUserControl
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
            labelTypeOfSwimming = new Label();
            labelDistance = new Label();
            labelKm = new Label();
            textBoxDistance = new TextBox();
            comboBoxTypeOfSwimming = new ComboBox();
            SuspendLayout();
            // 
            // labelTypeOfSwimming
            // 
            labelTypeOfSwimming.AutoSize = true;
            labelTypeOfSwimming.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelTypeOfSwimming.Location = new Point(3, 72);
            labelTypeOfSwimming.Name = "labelTypeOfSwimming";
            labelTypeOfSwimming.Size = new Size(136, 23);
            labelTypeOfSwimming.TabIndex = 0;
            labelTypeOfSwimming.Text = "Стиль плавания";
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
            // labelKm
            // 
            labelKm.AutoSize = true;
            labelKm.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelKm.Location = new Point(266, 40);
            labelKm.Name = "labelKm";
            labelKm.Size = new Size(30, 23);
            labelKm.TabIndex = 0;
            labelKm.Text = "км";
            // 
            // textBoxDistance
            // 
            textBoxDistance.Location = new Point(117, 36);
            textBoxDistance.Name = "textBoxDistance";
            textBoxDistance.Size = new Size(143, 27);
            textBoxDistance.TabIndex = 1;
            textBoxDistance.KeyPress += textBoxDistance_KeyPress;
            // 
            // comboBoxTypeOfSwimming
            // 
            comboBoxTypeOfSwimming.FormattingEnabled = true;
            comboBoxTypeOfSwimming.Location = new Point(145, 71);
            comboBoxTypeOfSwimming.Name = "comboBoxTypeOfSwimming";
            comboBoxTypeOfSwimming.Size = new Size(151, 28);
            comboBoxTypeOfSwimming.TabIndex = 2;
            comboBoxTypeOfSwimming.SelectedIndexChanged += comboBoxTypeOfSwimming_SelectedIndexChanged;
            // 
            // AddSwimmingUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBoxTypeOfSwimming);
            Controls.Add(textBoxDistance);
            Controls.Add(labelKm);
            Controls.Add(labelDistance);
            Controls.Add(labelTypeOfSwimming);
            Name = "AddSwimmingUserControl";
            Size = new Size(325, 122);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTypeOfSwimming;
        private Label labelDistance;
        private Label labelKm;
        private TextBox textBoxDistance;
        private ComboBox comboBoxTypeOfSwimming;
    }
}
