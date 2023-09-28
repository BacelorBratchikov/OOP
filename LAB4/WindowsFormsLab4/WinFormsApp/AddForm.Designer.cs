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
            Random = new Button();
            Cancel = new Button();
            OK = new Button();
            comboBoxExercise = new ComboBox();
            label_Chouse = new Label();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // Random
            // 
            Random.Location = new Point(209, 52);
            Random.Name = "Random";
            Random.Size = new Size(140, 30);
            Random.TabIndex = 26;
            Random.Text = "Случайная фигура";
            Random.UseVisualStyleBackColor = true;
            Random.Click += buttonRandom_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(209, 280);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(140, 30);
            Cancel.TabIndex = 25;
            Cancel.Text = "Отменить";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += buttonCancel_Click;
            // 
            // OK
            // 
            OK.Location = new Point(20, 280);
            OK.Name = "OK";
            OK.Size = new Size(140, 30);
            OK.TabIndex = 23;
            OK.Text = "Ok";
            OK.UseVisualStyleBackColor = true;
            OK.Click += buttonOK_Click;
            // 
            // comboBoxExercise
            // 
            comboBoxExercise.FormattingEnabled = true;
            comboBoxExercise.Location = new Point(20, 52);
            comboBoxExercise.Name = "comboBoxExercise";
            comboBoxExercise.Size = new Size(168, 28);
            comboBoxExercise.TabIndex = 22;
            comboBoxExercise.SelectedIndexChanged += comboBoxExercise_SelectedIndexChanged;
            // 
            // label_Chouse
            // 
            label_Chouse.AutoSize = true;
            label_Chouse.Location = new Point(20, 20);
            label_Chouse.Name = "label_Chouse";
            label_Chouse.Size = new Size(168, 20);
            label_Chouse.TabIndex = 21;
            label_Chouse.Text = "Выберете упражнение";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(20, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(329, 170);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Параметры упражнений";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(361, 325);
            Controls.Add(Random);
            Controls.Add(Cancel);
            Controls.Add(OK);
            Controls.Add(comboBoxExercise);
            Controls.Add(label_Chouse);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление упражнения";
            Load += AddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Random;
        private Button Cancel;
        private Button OK;
        private ComboBox comboBoxExercise;
        private Label label_Chouse;
        private AddBarbellPressUserControl addBarbellPressUserControl1;
        private AddRunningUserControl addRunningUserControl1;
        private AddSwimmingUserControl addSwimmingUserControl1;
        private GroupBox groupBox1;
    }
}