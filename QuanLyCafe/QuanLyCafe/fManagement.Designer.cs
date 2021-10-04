namespace QuanLyCafe
{
    partial class fManagement
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infomationsUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PriceTxt = new System.Windows.Forms.TextBox();
            this.listTable = new System.Windows.Forms.ComboBox();
            this.switchTable = new System.Windows.Forms.Button();
            this.Paybtn = new System.Windows.Forms.Button();
            this.ListBill = new System.Windows.Forms.ListView();
            this.colmn1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.numberFood = new System.Windows.Forms.NumericUpDown();
            this.AddFood = new System.Windows.Forms.Button();
            this.Food = new System.Windows.Forms.ComboBox();
            this.Catogory = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.numberDiscount = new System.Windows.Forms.NumericUpDown();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.userToolStripMenuItem,
            this.serviceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1217, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infomationsUserToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
            this.userToolStripMenuItem.Text = "User";
            // 
            // infomationsUserToolStripMenuItem
            // 
            this.infomationsUserToolStripMenuItem.Name = "infomationsUserToolStripMenuItem";
            this.infomationsUserToolStripMenuItem.Size = new System.Drawing.Size(252, 34);
            this.infomationsUserToolStripMenuItem.Text = "Infomation\'s user";
            this.infomationsUserToolStripMenuItem.Click += new System.EventHandler(this.infomationsUserToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(252, 34);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(642, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 317);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.PriceTxt);
            this.panel3.Controls.Add(this.listTable);
            this.panel3.Controls.Add(this.switchTable);
            this.panel3.Controls.Add(this.numberDiscount);
            this.panel3.Controls.Add(this.Paybtn);
            this.panel3.Location = new System.Drawing.Point(648, 591);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(557, 92);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "TOTAL: ";
            // 
            // PriceTxt
            // 
            this.PriceTxt.Font = new System.Drawing.Font(".VnArial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTxt.ForeColor = System.Drawing.Color.Black;
            this.PriceTxt.Location = new System.Drawing.Point(248, 47);
            this.PriceTxt.Multiline = true;
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.ReadOnly = true;
            this.PriceTxt.Size = new System.Drawing.Size(200, 36);
            this.PriceTxt.TabIndex = 7;
            this.PriceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listTable
            // 
            this.listTable.FormattingEnabled = true;
            this.listTable.Location = new System.Drawing.Point(0, 61);
            this.listTable.Name = "listTable";
            this.listTable.Size = new System.Drawing.Size(136, 28);
            this.listTable.TabIndex = 4;
            // 
            // switchTable
            // 
            this.switchTable.Location = new System.Drawing.Point(3, 7);
            this.switchTable.Name = "switchTable";
            this.switchTable.Size = new System.Drawing.Size(133, 42);
            this.switchTable.TabIndex = 6;
            this.switchTable.Text = "Switch";
            this.switchTable.UseVisualStyleBackColor = true;
            this.switchTable.Click += new System.EventHandler(this.switchTable_Click);
            // 
            // Paybtn
            // 
            this.Paybtn.Location = new System.Drawing.Point(454, 13);
            this.Paybtn.Name = "Paybtn";
            this.Paybtn.Size = new System.Drawing.Size(100, 70);
            this.Paybtn.TabIndex = 4;
            this.Paybtn.Text = "Pay";
            this.Paybtn.UseVisualStyleBackColor = true;
            this.Paybtn.Click += new System.EventHandler(this.Paybtn_Click);
            // 
            // ListBill
            // 
            this.ListBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colmn1,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ListBill.GridLines = true;
            this.ListBill.HideSelection = false;
            this.ListBill.Location = new System.Drawing.Point(645, 121);
            this.ListBill.Name = "ListBill";
            this.ListBill.Size = new System.Drawing.Size(554, 464);
            this.ListBill.TabIndex = 0;
            this.ListBill.UseCompatibleStateImageBehavior = false;
            this.ListBill.View = System.Windows.Forms.View.Details;
            this.ListBill.SelectedIndexChanged += new System.EventHandler(this.ListBill_SelectedIndexChanged);
            // 
            // colmn1
            // 
            this.colmn1.Text = "FOODNAME";
            this.colmn1.Width = 120;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "COUNT";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PRICE";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "TOTALPRICE";
            this.columnHeader3.Width = 141;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.numberFood);
            this.panel4.Controls.Add(this.AddFood);
            this.panel4.Controls.Add(this.Food);
            this.panel4.Controls.Add(this.Catogory);
            this.panel4.Location = new System.Drawing.Point(642, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(557, 79);
            this.panel4.TabIndex = 3;
            // 
            // numberFood
            // 
            this.numberFood.Location = new System.Drawing.Point(463, 24);
            this.numberFood.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numberFood.Name = "numberFood";
            this.numberFood.Size = new System.Drawing.Size(75, 26);
            this.numberFood.TabIndex = 3;
            this.numberFood.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddFood
            // 
            this.AddFood.Location = new System.Drawing.Point(345, 8);
            this.AddFood.Name = "AddFood";
            this.AddFood.Size = new System.Drawing.Size(100, 57);
            this.AddFood.TabIndex = 2;
            this.AddFood.Text = "Add";
            this.AddFood.UseVisualStyleBackColor = true;
            this.AddFood.Click += new System.EventHandler(this.button1_Click);
            // 
            // Food
            // 
            this.Food.FormattingEnabled = true;
            this.Food.Location = new System.Drawing.Point(0, 37);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(339, 28);
            this.Food.TabIndex = 1;
            // 
            // Catogory
            // 
            this.Catogory.FormattingEnabled = true;
            this.Catogory.Location = new System.Drawing.Point(3, 3);
            this.Catogory.Name = "Catogory";
            this.Catogory.Size = new System.Drawing.Size(223, 28);
            this.Catogory.TabIndex = 0;
            this.Catogory.SelectedIndexChanged += new System.EventHandler(this.Catogory_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(623, 647);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // numberDiscount
            // 
            this.numberDiscount.Location = new System.Drawing.Point(142, 13);
            this.numberDiscount.Name = "numberDiscount";
            this.numberDiscount.Size = new System.Drawing.Size(100, 26);
            this.numberDiscount.TabIndex = 4;
            this.numberDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payToolStripMenuItem});
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.serviceToolStripMenuItem.Text = "Service";
            // 
            // payToolStripMenuItem
            // 
            this.payToolStripMenuItem.Name = "payToolStripMenuItem";
            this.payToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.payToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.payToolStripMenuItem.Text = "Pay";
            this.payToolStripMenuItem.Click += new System.EventHandler(this.payToolStripMenuItem_Click);
            // 
            // fManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 722);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ListBill);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fManagement";
            this.Text = "Cafe Shop";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numberFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infomationsUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView ListBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox Food;
        private System.Windows.Forms.ComboBox Catogory;
        private System.Windows.Forms.Button AddFood;
        private System.Windows.Forms.ComboBox listTable;
        private System.Windows.Forms.Button switchTable;
        private System.Windows.Forms.Button Paybtn;
        private System.Windows.Forms.NumericUpDown numberFood;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ColumnHeader colmn1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PriceTxt;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numberDiscount;
    }
}