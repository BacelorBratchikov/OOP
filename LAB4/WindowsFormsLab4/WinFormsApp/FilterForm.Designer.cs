namespace WinFormsApp
{
    partial class FilterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterForm));
            groupBox1 = new GroupBox();
            CaloriiCheckBox = new CheckBox();
            SwimmingCheckBox = new CheckBox();
            RunningCheckBox = new CheckBox();
            label1_cal = new Label();
            CaloriiTextBox = new TextBox();
            BarbellPressCheckBox = new CheckBox();
            FilterButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CaloriiCheckBox);
            groupBox1.Controls.Add(SwimmingCheckBox);
            groupBox1.Controls.Add(RunningCheckBox);
            groupBox1.Controls.Add(label1_cal);
            groupBox1.Controls.Add(CaloriiTextBox);
            groupBox1.Controls.Add(BarbellPressCheckBox);
            groupBox1.Location = new Point(20, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(226, 149);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Параметры фильтрации";
            // 
            // CaloriiCheckBox
            // 
            CaloriiCheckBox.AutoSize = true;
            CaloriiCheckBox.Location = new Point(10, 118);
            CaloriiCheckBox.Name = "CaloriiCheckBox";
            CaloriiCheckBox.Size = new Size(92, 24);
            CaloriiCheckBox.TabIndex = 6;
            CaloriiCheckBox.Text = "Калории";
            CaloriiCheckBox.UseVisualStyleBackColor = true;
            CaloriiCheckBox.CheckedChanged += checkBoxCalorii_CheckedChanged;
            // 
            // SwimmingCheckBox
            // 
            SwimmingCheckBox.AutoSize = true;
            SwimmingCheckBox.Checked = true;
            SwimmingCheckBox.Location = new Point(10, 87);
            SwimmingCheckBox.Name = "SwimmingCheckBox";
            SwimmingCheckBox.Size = new Size(100, 24);
            SwimmingCheckBox.TabIndex = 5;
            SwimmingCheckBox.Text = "Плавание";
            SwimmingCheckBox.UseVisualStyleBackColor = true;
            // 
            // RunningCheckBox
            // 
            RunningCheckBox.AutoSize = true;
            RunningCheckBox.Checked = true;
            RunningCheckBox.Location = new Point(10, 56);
            RunningCheckBox.Name = "RunningCheckBox";
            RunningCheckBox.Size = new Size(54, 24);
            RunningCheckBox.TabIndex = 4;
            RunningCheckBox.Text = "Бег";
            RunningCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1_cal
            // 
            label1_cal.AutoSize = true;
            label1_cal.Location = new Point(181, 118);
            label1_cal.Name = "label1_cal";
            label1_cal.Size = new Size(39, 20);
            label1_cal.TabIndex = 3;
            label1_cal.Text = "ккал";
            // 
            // CaloriiTextBox
            // 
            CaloriiTextBox.Location = new Point(112, 115);
            CaloriiTextBox.Name = "CaloriiTextBox";
            CaloriiTextBox.Size = new Size(63, 27);
            CaloriiTextBox.TabIndex = 2;
            CaloriiTextBox.TextChanged += textBoxCalorii_TextChanged;
            CaloriiTextBox.KeyPress += textBoxCalorii_KeyPress;
            // 
            // BarbellPressCheckBox
            // 
            BarbellPressCheckBox.AutoSize = true;
            BarbellPressCheckBox.Checked = true;
            BarbellPressCheckBox.Location = new Point(10, 26);
            BarbellPressCheckBox.Name = "BarbellPressCheckBox";
            BarbellPressCheckBox.Size = new Size(118, 24);
            BarbellPressCheckBox.TabIndex = 1;
            BarbellPressCheckBox.Text = "Жим штанги";
            BarbellPressCheckBox.UseVisualStyleBackColor = true;
            // 
            // FilterButton
            // 
            FilterButton.Location = new Point(30, 174);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(200, 30);
            FilterButton.TabIndex = 1;
            FilterButton.Text = "Запуск фильтра";
            FilterButton.UseVisualStyleBackColor = true;
            FilterButton.Click += buttonFilter_Click;
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(271, 216);
            Controls.Add(FilterButton);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FilterForm";
            Text = "Фильтр";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1_cal;
        private TextBox CaloriiTextBox;
        private CheckBox BarbellPressCheckBox;
        private Button FilterButton;
        private CheckBox CaloriiCheckBox;
        private CheckBox SwimmingCheckBox;
        private CheckBox RunningCheckBox;
    }
}