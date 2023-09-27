namespace WindowsForms
{
    partial class MainForms
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForms));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.SaveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CleanAllButton = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(552, 30);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveFileToolStripMenuItem,
            this.LoadFileToolStripMenuItem});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(64, 27);
            this.toolStripDropDownButton1.Text = "Файл";
            // 
            // SaveFileToolStripMenuItem
            // 
            this.SaveFileToolStripMenuItem.Name = "SaveFileToolStripMenuItem";
            this.SaveFileToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.SaveFileToolStripMenuItem.Text = "Сохранить файл";
            this.SaveFileToolStripMenuItem.Click += new System.EventHandler(this.SaveFileToolStripMenuItem_Click);
            // 
            // LoadFileToolStripMenuItem
            // 
            this.LoadFileToolStripMenuItem.Name = "LoadFileToolStripMenuItem";
            this.LoadFileToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.LoadFileToolStripMenuItem.Text = "Загрузить файл";
            this.LoadFileToolStripMenuItem.Click += new System.EventHandler(this.LoadFileToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(75, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 242);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список упражнений";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(433, 201);
            this.dataGridView1.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.Color.Transparent;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(12, 46);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(57, 52);
            this.AddButton.TabIndex = 2;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.ForeColor = System.Drawing.Color.Transparent;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(12, 104);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(57, 52);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // CleanAllButton
            // 
            this.CleanAllButton.BackColor = System.Drawing.Color.Transparent;
            this.CleanAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CleanAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CleanAllButton.FlatAppearance.BorderSize = 0;
            this.CleanAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CleanAllButton.ForeColor = System.Drawing.Color.Transparent;
            this.CleanAllButton.Image = ((System.Drawing.Image)(resources.GetObject("CleanAllButton.Image")));
            this.CleanAllButton.Location = new System.Drawing.Point(12, 233);
            this.CleanAllButton.Name = "CleanAllButton";
            this.CleanAllButton.Size = new System.Drawing.Size(57, 52);
            this.CleanAllButton.TabIndex = 2;
            this.CleanAllButton.UseVisualStyleBackColor = false;
            // 
            // FilterButton
            // 
            this.FilterButton.BackColor = System.Drawing.Color.Transparent;
            this.FilterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FilterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FilterButton.FlatAppearance.BorderSize = 0;
            this.FilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterButton.ForeColor = System.Drawing.Color.Transparent;
            this.FilterButton.Image = ((System.Drawing.Image)(resources.GetObject("FilterButton.Image")));
            this.FilterButton.Location = new System.Drawing.Point(12, 175);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(57, 52);
            this.FilterButton.TabIndex = 2;
            this.FilterButton.UseVisualStyleBackColor = false;
            // 
            // MainForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(552, 328);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.CleanAllButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Счетчик калорий";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem SaveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadFileToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CleanAllButton;
        private System.Windows.Forms.Button FilterButton;
    }
}

