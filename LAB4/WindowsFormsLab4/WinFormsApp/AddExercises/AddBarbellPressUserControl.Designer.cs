namespace WinFormsApp
{
    partial class AddBarbellPressUserControl
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
            labelRepetitions = new Label();
            labelWeight = new Label();
            labelRaz = new Label();
            labelKg = new Label();
            textBoxRepetitions = new TextBox();
            textBoxWeight = new TextBox();
            SuspendLayout();
            // 
            // labelRepetitions
            // 
            labelRepetitions.AutoSize = true;
            labelRepetitions.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelRepetitions.Location = new Point(16, 36);
            labelRepetitions.Name = "labelRepetitions";
            labelRepetitions.Size = new Size(106, 23);
            labelRepetitions.TabIndex = 0;
            labelRepetitions.Text = "Повторения";
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelWeight.Location = new Point(16, 72);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(37, 23);
            labelWeight.TabIndex = 0;
            labelWeight.Text = "Вес";
            // 
            // labelRaz
            // 
            labelRaz.AutoSize = true;
            labelRaz.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelRaz.Location = new Point(259, 36);
            labelRaz.Name = "labelRaz";
            labelRaz.Size = new Size(37, 23);
            labelRaz.TabIndex = 0;
            labelRaz.Text = "раз";
            // 
            // labelKg
            // 
            labelKg.AutoSize = true;
            labelKg.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelKg.Location = new Point(259, 72);
            labelKg.Name = "labelKg";
            labelKg.Size = new Size(25, 23);
            labelKg.TabIndex = 0;
            labelKg.Text = "кг";
            // 
            // textBoxRepetitions
            // 
            textBoxRepetitions.Location = new Point(128, 32);
            textBoxRepetitions.Name = "textBoxRepetitions";
            textBoxRepetitions.Size = new Size(125, 27);
            textBoxRepetitions.TabIndex = 1;
            textBoxRepetitions.KeyPress += TextBoxCheckKeyPress;
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(128, 68);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(125, 27);
            textBoxWeight.TabIndex = 1;
            textBoxWeight.KeyPress += TextBoxCheckKeyPress;
            // 
            // AddBarbellPressUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxWeight);
            Controls.Add(textBoxRepetitions);
            Controls.Add(labelKg);
            Controls.Add(labelRaz);
            Controls.Add(labelWeight);
            Controls.Add(labelRepetitions);
            Name = "AddBarbellPressUserControl";
            Size = new Size(309, 122);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRepetitions;
        private Label labelWeight;
        private Label labelRaz;
        private Label labelKg;
        private TextBox textBoxRepetitions;
        private TextBox textBoxWeight;
    }
}
