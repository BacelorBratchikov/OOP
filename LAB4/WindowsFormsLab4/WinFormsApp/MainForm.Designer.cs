using System.Windows.Forms;

namespace WinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            SaveFileToolStripMenuItem = new ToolStripMenuItem();
            LoadFileToolStripMenuItem = new ToolStripMenuItem();
            AddButton = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            DeleteButton = new Button();
            FilterButton = new Button();
            CleanAllButton = new Button();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Gainsboro;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(730, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { SaveFileToolStripMenuItem, LoadFileToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(59, 24);
            toolStripDropDownButton1.Text = "Файл";
            // 
            // SaveFileToolStripMenuItem
            // 
            SaveFileToolStripMenuItem.Name = "SaveFileToolStripMenuItem";
            SaveFileToolStripMenuItem.Size = new Size(205, 26);
            SaveFileToolStripMenuItem.Text = "Сохранить файл";
            SaveFileToolStripMenuItem.Click += SaveFileToolStripMenuItem_Click;
            // 
            // LoadFileToolStripMenuItem
            // 
            LoadFileToolStripMenuItem.Name = "LoadFileToolStripMenuItem";
            LoadFileToolStripMenuItem.Size = new Size(205, 26);
            LoadFileToolStripMenuItem.Text = "Загрузить файл";
            LoadFileToolStripMenuItem.Click += LoadFileToolStripMenuItem_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.Transparent;
            AddButton.Cursor = Cursors.Hand;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Image = (Image)resources.GetObject("AddButton.Image");
            AddButton.Location = new Point(12, 52);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(55, 55);
            AddButton.TabIndex = 1;
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.LightCyan;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(6, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(633, 214);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(73, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(645, 286);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Список упражнений";
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.Transparent;
            DeleteButton.Cursor = Cursors.Hand;
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Image = (Image)resources.GetObject("DeleteButton.Image");
            DeleteButton.Location = new Point(12, 113);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(55, 55);
            DeleteButton.TabIndex = 1;
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // FilterButton
            // 
            FilterButton.BackColor = Color.Transparent;
            FilterButton.Cursor = Cursors.Hand;
            FilterButton.FlatAppearance.BorderSize = 0;
            FilterButton.FlatStyle = FlatStyle.Flat;
            FilterButton.Image = (Image)resources.GetObject("FilterButton.Image");
            FilterButton.Location = new Point(12, 174);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(55, 55);
            FilterButton.TabIndex = 1;
            FilterButton.UseVisualStyleBackColor = false;
            FilterButton.Click += FilterButton_Click;
            // 
            // CleanAllButton
            // 
            CleanAllButton.BackColor = Color.Transparent;
            CleanAllButton.Cursor = Cursors.Hand;
            CleanAllButton.FlatAppearance.BorderSize = 0;
            CleanAllButton.FlatStyle = FlatStyle.Flat;
            CleanAllButton.Image = (Image)resources.GetObject("CleanAllButton.Image");
            CleanAllButton.Location = new Point(12, 235);
            CleanAllButton.Name = "CleanAllButton";
            CleanAllButton.Size = new Size(55, 55);
            CleanAllButton.TabIndex = 1;
            CleanAllButton.UseVisualStyleBackColor = false;
            CleanAllButton.Click += CleanAllButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(730, 343);
            Controls.Add(groupBox1);
            Controls.Add(CleanAllButton);
            Controls.Add(FilterButton);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(toolStrip1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            RightToLeft = RightToLeft.No;
            Text = "Счетчик калорий";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private Button AddButton;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button DeleteButton;
        private Button FilterButton;
        private Button CleanAllButton;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem SaveFileToolStripMenuItem;
        private ToolStripMenuItem LoadFileToolStripMenuItem;
    }
}