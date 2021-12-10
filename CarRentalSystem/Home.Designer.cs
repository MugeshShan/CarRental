namespace CarRentalSystem
{
    partial class Home
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
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.RentalCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.MenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RentalCarToolStripMenuItem,
            this.CustomerToolStripMenuItem,
            this.NewCarToolStripMenuItem,
            this.SearchToolStripMenuItem,
            this.categoryManagementToolStripMenuItem,
            this.paymentToolStripMenuItem,
            this.toolStripMenuItem1});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(714, 24);
            this.MenuStrip1.TabIndex = 1;
            this.MenuStrip1.Text = "MenuStrip1";
            this.MenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // RentalCarToolStripMenuItem
            // 
            this.RentalCarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.RentalCarToolStripMenuItem.Name = "RentalCarToolStripMenuItem";
            this.RentalCarToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.RentalCarToolStripMenuItem.Text = "Rental Car";
            this.RentalCarToolStripMenuItem.Click += new System.EventHandler(this.RentalCarToolStripMenuItem_Click);
            // 
            // CustomerToolStripMenuItem
            // 
            this.CustomerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem";
            this.CustomerToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.CustomerToolStripMenuItem.Text = "New Customer";
            this.CustomerToolStripMenuItem.Click += new System.EventHandler(this.CustomerToolStripMenuItem_Click);
            // 
            // NewCarToolStripMenuItem
            // 
            this.NewCarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.NewCarToolStripMenuItem.Name = "NewCarToolStripMenuItem";
            this.NewCarToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.NewCarToolStripMenuItem.Text = "New Car";
            this.NewCarToolStripMenuItem.Click += new System.EventHandler(this.NewCarToolStripMenuItem_Click);
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CarToolStripMenuItem,
            this.CustomerToolStripMenuItem1});
            this.SearchToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.SearchToolStripMenuItem.Text = "Search";
            // 
            // CarToolStripMenuItem
            // 
            this.CarToolStripMenuItem.Name = "CarToolStripMenuItem";
            this.CarToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.CarToolStripMenuItem.Text = "Car";
            this.CarToolStripMenuItem.Click += new System.EventHandler(this.CarToolStripMenuItem_Click);
            // 
            // CustomerToolStripMenuItem1
            // 
            this.CustomerToolStripMenuItem1.Name = "CustomerToolStripMenuItem1";
            this.CustomerToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.CustomerToolStripMenuItem1.Text = "Customer";
            this.CustomerToolStripMenuItem1.Click += new System.EventHandler(this.CustomerToolStripMenuItem1_Click);
            // 
            // categoryManagementToolStripMenuItem
            // 
            this.categoryManagementToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.categoryManagementToolStripMenuItem.Name = "categoryManagementToolStripMenuItem";
            this.categoryManagementToolStripMenuItem.Size = new System.Drawing.Size(176, 20);
            this.categoryManagementToolStripMenuItem.Text = "Category Management";
            this.categoryManagementToolStripMenuItem.Click += new System.EventHandler(this.categoryManagementToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(45, 20);
            this.toolStripMenuItem1.Text = "Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(638, 425);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.paymentToolStripMenuItem.Text = "Payment";
            this.paymentToolStripMenuItem.Click += new System.EventHandler(this.paymentToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "Home";
            this.Text = "Home";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem RentalCarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CustomerToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem NewCarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CustomerToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoryManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
    }
}