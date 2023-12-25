namespace WinFormsApp
{
    partial class AddForm
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
            random = new Button();
            cancel = new Button();
            buttonOk = new Button();
            comboBoxExercise = new ComboBox();
            labelChouse = new Label();
            groupBox1 = new GroupBox();
            addSwimmingUserControl1 = new AddSwimmingUserControl();
            addRunningUserControl1 = new AddRunningUserControl();
            addBarbellPressUserControl1 = new AddBarbellPressUserControl();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Random
            // 
            random.Location = new Point(209, 52);
            random.Name = "Random";
            random.Size = new Size(140, 30);
            random.TabIndex = 26;
            random.Text = "Случайная фигура";
            random.UseVisualStyleBackColor = true;
            random.Click += ButtonRandomClick;
            // 
            // Cancel
            // 
            cancel.Location = new Point(209, 280);
            cancel.Name = "Cancel";
            cancel.Size = new Size(140, 30);
            cancel.TabIndex = 25;
            cancel.Text = "Закрыть";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += ButtonCancelClick;
            // 
            // OK
            // 
            buttonOk.Location = new Point(20, 280);
            buttonOk.Name = "OK";
            buttonOk.Size = new Size(140, 30);
            buttonOk.TabIndex = 23;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += ButtonOkClick;
            // 
            // comboBoxExercise
            // 
            comboBoxExercise.FormattingEnabled = true;
            comboBoxExercise.Location = new Point(20, 52);
            comboBoxExercise.Name = "comboBoxExercise";
            comboBoxExercise.Size = new Size(168, 28);
            comboBoxExercise.TabIndex = 22;
            comboBoxExercise.SelectedIndexChanged += ComboBoxExerciseSelectedIndexChanged;
            // 
            // label_Chouse
            // 
            labelChouse.AutoSize = true;
            labelChouse.Location = new Point(20, 20);
            labelChouse.Name = "label_Chouse";
            labelChouse.Size = new Size(168, 20);
            labelChouse.TabIndex = 21;
            labelChouse.Text = "Выберете упражнение";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(addSwimmingUserControl1);
            groupBox1.Controls.Add(addRunningUserControl1);
            groupBox1.Controls.Add(addBarbellPressUserControl1);
            groupBox1.Location = new Point(20, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(329, 170);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Параметры упражнений";
            // 
            // addSwimmingUserControl1
            // 
            addSwimmingUserControl1.Location = new Point(2, 34);
            addSwimmingUserControl1.Name = "addSwimmingUserControl1";
            addSwimmingUserControl1.Size = new Size(322, 130);
            addSwimmingUserControl1.TabIndex = 2;
            // 
            // addRunningUserControl1
            // 
            addRunningUserControl1.Location = new Point(2, 29);
            addRunningUserControl1.Name = "addRunningUserControl1";
            addRunningUserControl1.Size = new Size(321, 113);
            addRunningUserControl1.TabIndex = 1;
            // 
            // addBarbellPressUserControl1
            // 
            addBarbellPressUserControl1.Location = new Point(6, 26);
            addBarbellPressUserControl1.Name = "addBarbellPressUserControl1";
            addBarbellPressUserControl1.Size = new Size(318, 116);
            addBarbellPressUserControl1.TabIndex = 0;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(361, 325);
            Controls.Add(random);
            Controls.Add(cancel);
            Controls.Add(buttonOk);
            Controls.Add(comboBoxExercise);
            Controls.Add(labelChouse);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление упражнения";
            Load += AddFormLoad;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button random;
        private Button cancel;
        private Button buttonOk;
        private ComboBox comboBoxExercise;
        private Label labelChouse;
        private AddBarbellPressUserControl addBarbellPressUserControl1;
        private AddRunningUserControl addRunningUserControl1;
        private AddSwimmingUserControl addSwimmingUserControl1;
        private GroupBox groupBox1;
    }
}