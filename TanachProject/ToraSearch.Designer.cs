namespace PL_presentation
{
    partial class ToraSearch
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
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            menuStrip1 = new MenuStrip();
            חיפושרגלToolStripMenuItem = new ToolStripMenuItem();
            חיפושרגילToolStripMenuItem = new ToolStripMenuItem();
            חיפושלפישורשToolStripMenuItem = new ToolStripMenuItem();
            חיפושלפינושאToolStripMenuItem = new ToolStripMenuItem();
            חיפושמשולבToolStripMenuItem = new ToolStripMenuItem();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button3 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Cursor = Cursors.No;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(399, 46);
            label1.Name = "label1";
            label1.Size = new Size(244, 25);
            label1.TabIndex = 1;
            label1.Text = "הכנס ערך ובחר אפשרות חיפוש";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Fb LotusBook", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(395, 136);
            button1.Name = "button1";
            button1.Size = new Size(84, 37);
            button1.TabIndex = 2;
            button1.Text = "חפש";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.GradientActiveCaption;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(395, 93);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(142, 28);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { חיפושרגלToolStripMenuItem });
            menuStrip1.Location = new Point(4, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 6, 5, 6);
            menuStrip1.Size = new Size(1126, 39);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // חיפושרגלToolStripMenuItem
            // 
            חיפושרגלToolStripMenuItem.BackColor = SystemColors.GradientActiveCaption;
            חיפושרגלToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { חיפושרגילToolStripMenuItem, חיפושלפישורשToolStripMenuItem, חיפושלפינושאToolStripMenuItem, חיפושמשולבToolStripMenuItem });
            חיפושרגלToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            חיפושרגלToolStripMenuItem.ForeColor = SystemColors.HotTrack;
            חיפושרגלToolStripMenuItem.Name = "חיפושרגלToolStripMenuItem";
            חיפושרגלToolStripMenuItem.Size = new Size(146, 27);
            חיפושרגלToolStripMenuItem.Text = "אפשרויות חיפוש";
            חיפושרגלToolStripMenuItem.Click += חיפושרגלToolStripMenuItem_Click;
            // 
            // חיפושרגילToolStripMenuItem
            // 
            חיפושרגילToolStripMenuItem.BackColor = Color.LightBlue;
            חיפושרגילToolStripMenuItem.Name = "חיפושרגילToolStripMenuItem";
            חיפושרגילToolStripMenuItem.Size = new Size(237, 28);
            חיפושרגילToolStripMenuItem.Text = "חיפוש רגיל";
            חיפושרגילToolStripMenuItem.Click += חיפושרגילToolStripMenuItem_Click;
            // 
            // חיפושלפישורשToolStripMenuItem
            // 
            חיפושלפישורשToolStripMenuItem.BackColor = SystemColors.InactiveCaption;
            חיפושלפישורשToolStripMenuItem.Name = "חיפושלפישורשToolStripMenuItem";
            חיפושלפישורשToolStripMenuItem.Size = new Size(237, 28);
            חיפושלפישורשToolStripMenuItem.Text = "חיפוש ראשי תבות";
            חיפושלפישורשToolStripMenuItem.Click += חיפושלפישורשToolStripMenuItem_Click;
            // 
            // חיפושלפינושאToolStripMenuItem
            // 
            חיפושלפינושאToolStripMenuItem.BackColor = SystemColors.GradientActiveCaption;
            חיפושלפינושאToolStripMenuItem.Name = "חיפושלפינושאToolStripMenuItem";
            חיפושלפינושאToolStripMenuItem.Size = new Size(237, 28);
            חיפושלפינושאToolStripMenuItem.Text = "חיפוש אמצעי תבות";
            חיפושלפינושאToolStripMenuItem.Click += חיפושלפינושאToolStripMenuItem_Click;
            // 
            // חיפושמשולבToolStripMenuItem
            // 
            חיפושמשולבToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            חיפושמשולבToolStripMenuItem.Name = "חיפושמשולבToolStripMenuItem";
            חיפושמשולבToolStripMenuItem.Size = new Size(237, 28);
            חיפושמשולבToolStripMenuItem.Text = "חיפוש משולב";
            חיפושמשולבToolStripMenuItem.Click += חיפושמשולבToolStripMenuItem_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.HotTrack;
            button2.Location = new Point(142, 529);
            button2.Name = "button2";
            button2.Size = new Size(137, 39);
            button2.TabIndex = 7;
            button2.Text = "הצג עוד תוצאות";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 191);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(957, 326);
            dataGridView1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Location = new Point(19, 191);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(957, 326);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.HotTrack;
            button3.Location = new Point(471, 529);
            button3.Name = "button3";
            button3.Size = new Size(180, 39);
            button3.TabIndex = 8;
            button3.Text = "הצג את כל התורה";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // ToraSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 587);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
            Name = "ToraSearch";
            Padding = new Padding(4, 3, 4, 3);
            RightToLeft = RightToLeft.Yes;
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem חיפושרגלToolStripMenuItem;
        private ToolStripMenuItem חיפושרגילToolStripMenuItem;
        private ToolStripMenuItem חיפושלפישורשToolStripMenuItem;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button3;
        private ToolStripMenuItem חיפושלפינושאToolStripMenuItem;
        private ToolStripMenuItem חיפושמשולבToolStripMenuItem;
    }
}
