namespace JMD.GUI.mainGUI
{
    partial class JMDMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JMDMain));
            this.slidingPanel = new MetroFramework.Controls.MetroPanel();
            this.inventory = new MetroFramework.Controls.MetroButton();
            this.viewOrders = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.buyBtn = new MetroFramework.Controls.MetroButton();
            this.slidingBtn_toggel = new MetroFramework.Controls.MetroButton();
            this.ContentPanel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.slidingPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // slidingPanel
            // 
            this.slidingPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.slidingPanel.Controls.Add(this.metroButton2);
            this.slidingPanel.Controls.Add(this.inventory);
            this.slidingPanel.Controls.Add(this.viewOrders);
            this.slidingPanel.Controls.Add(this.metroLabel2);
            this.slidingPanel.Controls.Add(this.metroButton1);
            this.slidingPanel.Controls.Add(this.buyBtn);
            this.slidingPanel.Controls.Add(this.slidingBtn_toggel);
            this.slidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidingPanel.HorizontalScrollbarBarColor = true;
            this.slidingPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.slidingPanel.HorizontalScrollbarSize = 10;
            this.slidingPanel.Location = new System.Drawing.Point(20, 60);
            this.slidingPanel.Name = "slidingPanel";
            this.slidingPanel.Size = new System.Drawing.Size(200, 620);
            this.slidingPanel.Style = MetroFramework.MetroColorStyle.Blue;
            this.slidingPanel.TabIndex = 0;
            this.slidingPanel.UseCustomBackColor = true;
            this.slidingPanel.UseStyleColors = true;
            this.slidingPanel.VerticalScrollbarBarColor = true;
            this.slidingPanel.VerticalScrollbarHighlightOnWheel = false;
            this.slidingPanel.VerticalScrollbarSize = 10;
            // 
            // inventory
            // 
            this.inventory.Location = new System.Drawing.Point(0, 228);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(200, 51);
            this.inventory.TabIndex = 7;
            this.inventory.Text = "Inventory";
            this.inventory.UseSelectable = true;
            this.inventory.Click += new System.EventHandler(this.Inventory_Click);
            // 
            // viewOrders
            // 
            this.viewOrders.Location = new System.Drawing.Point(0, 57);
            this.viewOrders.Name = "viewOrders";
            this.viewOrders.Size = new System.Drawing.Size(200, 51);
            this.viewOrders.TabIndex = 6;
            this.viewOrders.Text = "View Orders";
            this.viewOrders.UseSelectable = true;
            this.viewOrders.Click += new System.EventHandler(this.ViewOrders_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 590);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(0, 0);
            this.metroLabel2.TabIndex = 5;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(0, 171);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(200, 51);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Insert Food";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // buyBtn
            // 
            this.buyBtn.Location = new System.Drawing.Point(0, 114);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(200, 51);
            this.buyBtn.TabIndex = 3;
            this.buyBtn.Text = "Buy";
            this.buyBtn.UseSelectable = true;
            this.buyBtn.Click += new System.EventHandler(this.BuyBtn_Click);
            // 
            // slidingBtn_toggel
            // 
            this.slidingBtn_toggel.BackColor = System.Drawing.Color.White;
            this.slidingBtn_toggel.Location = new System.Drawing.Point(0, 0);
            this.slidingBtn_toggel.Name = "slidingBtn_toggel";
            this.slidingBtn_toggel.Size = new System.Drawing.Size(200, 51);
            this.slidingBtn_toggel.TabIndex = 2;
            this.slidingBtn_toggel.Text = "Home Screen";
            this.slidingBtn_toggel.UseSelectable = true;
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackgroundImage = global::JMD.Properties.Resources.Home_Screen;
            this.ContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ContentPanel.Controls.Add(this.metroLabel1);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPanel.HorizontalScrollbarBarColor = true;
            this.ContentPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ContentPanel.HorizontalScrollbarSize = 10;
            this.ContentPanel.Location = new System.Drawing.Point(240, 60);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(990, 620);
            this.ContentPanel.TabIndex = 1;
            this.ContentPanel.VerticalScrollbarBarColor = true;
            this.ContentPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ContentPanel.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(427, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(121, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Welcome To ";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(0, 285);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(200, 51);
            this.metroButton2.TabIndex = 8;
            this.metroButton2.Text = "Add Users";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.MetroButton2_Click);
            // 
            // JMDMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.slidingPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JMDMain";
            this.Text = "JMDMain";
            this.slidingPanel.ResumeLayout(false);
            this.slidingPanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel slidingPanel;
        private MetroFramework.Controls.MetroButton slidingBtn_toggel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton buyBtn;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroPanel ContentPanel;
        private MetroFramework.Controls.MetroButton viewOrders;
        private MetroFramework.Controls.MetroButton inventory;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}