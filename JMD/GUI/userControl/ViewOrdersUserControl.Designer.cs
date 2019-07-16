namespace JMD.GUI.userControl
{
    partial class ViewOrdersUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jMDDatabaseDataSet1 = new JMD.JMDDatabaseDataSet1();
            this.oRDERSTableAdapter = new JMD.JMDDatabaseDataSet1TableAdapters.ORDERSTableAdapter();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.FinsihOrder = new MetroFramework.Controls.MetroButton();
            this.orderNumber2 = new MetroFramework.Controls.MetroLabel();
            this.OrderNumber1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.grandTotaltxt = new MetroFramework.Controls.MetroLabel();
            this.searchBox = new MetroFramework.Controls.MetroTextBox();
            this.search = new MetroFramework.Controls.MetroButton();
            this.next = new MetroFramework.Controls.MetroButton();
            this.previous = new MetroFramework.Controls.MetroButton();
            this.refreshBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jMDDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.orderNumberDataGridViewTextBoxColumn,
            this.foodNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oRDERSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "orderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "orderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "orderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "orderNumber";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            // 
            // foodNameDataGridViewTextBoxColumn
            // 
            this.foodNameDataGridViewTextBoxColumn.DataPropertyName = "FoodName";
            this.foodNameDataGridViewTextBoxColumn.HeaderText = "FoodName";
            this.foodNameDataGridViewTextBoxColumn.Name = "foodNameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // oRDERSBindingSource
            // 
            this.oRDERSBindingSource.DataMember = "ORDERS";
            this.oRDERSBindingSource.DataSource = this.jMDDatabaseDataSet1;
            // 
            // jMDDatabaseDataSet1
            // 
            this.jMDDatabaseDataSet1.DataSetName = "JMDDatabaseDataSet1";
            this.jMDDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oRDERSTableAdapter
            // 
            this.oRDERSTableAdapter.ClearBeforeFill = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(348, 38);
            this.metroLabel1.MaximumSize = new System.Drawing.Size(500, 200);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "View Orders";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(648, 122);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Select Order";
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 579;
            this.lineShape1.X2 = 961;
            this.lineShape1.Y1 = 191;
            this.lineShape1.Y2 = 190;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(990, 617);
            this.shapeContainer1.TabIndex = 16;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 576;
            this.lineShape2.X2 = 958;
            this.lineShape2.Y1 = 360;
            this.lineShape2.Y2 = 359;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(602, 232);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(129, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Finish Current Order";
            // 
            // FinsihOrder
            // 
            this.FinsihOrder.BackColor = System.Drawing.Color.Green;
            this.FinsihOrder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FinsihOrder.Location = new System.Drawing.Point(759, 291);
            this.FinsihOrder.Name = "FinsihOrder";
            this.FinsihOrder.Size = new System.Drawing.Size(75, 23);
            this.FinsihOrder.TabIndex = 19;
            this.FinsihOrder.Text = "Finish";
            this.FinsihOrder.UseCustomBackColor = true;
            this.FinsihOrder.UseCustomForeColor = true;
            this.FinsihOrder.UseSelectable = true;
            this.FinsihOrder.Click += new System.EventHandler(this.FinsihOrder_Click);
            // 
            // orderNumber2
            // 
            this.orderNumber2.AutoSize = true;
            this.orderNumber2.Location = new System.Drawing.Point(759, 232);
            this.orderNumber2.Name = "orderNumber2";
            this.orderNumber2.Size = new System.Drawing.Size(98, 19);
            this.orderNumber2.TabIndex = 22;
            this.orderNumber2.Text = "Order Number";
            // 
            // OrderNumber1
            // 
            this.OrderNumber1.AutoSize = true;
            this.OrderNumber1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.OrderNumber1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.OrderNumber1.Location = new System.Drawing.Point(442, 90);
            this.OrderNumber1.MaximumSize = new System.Drawing.Size(500, 200);
            this.OrderNumber1.Name = "OrderNumber1";
            this.OrderNumber1.Size = new System.Drawing.Size(22, 25);
            this.OrderNumber1.TabIndex = 23;
            this.OrderNumber1.Text = "0";
            this.OrderNumber1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(21, 400);
            this.metroLabel6.MaximumSize = new System.Drawing.Size(500, 200);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(97, 25);
            this.metroLabel6.TabIndex = 24;
            this.metroLabel6.Text = "GrandTotal";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grandTotaltxt
            // 
            this.grandTotaltxt.AutoSize = true;
            this.grandTotaltxt.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.grandTotaltxt.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.grandTotaltxt.Location = new System.Drawing.Point(147, 400);
            this.grandTotaltxt.MaximumSize = new System.Drawing.Size(500, 200);
            this.grandTotaltxt.Name = "grandTotaltxt";
            this.grandTotaltxt.Size = new System.Drawing.Size(22, 25);
            this.grandTotaltxt.TabIndex = 25;
            this.grandTotaltxt.Text = "0";
            this.grandTotaltxt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // searchBox
            // 
            // 
            // 
            // 
            this.searchBox.CustomButton.Image = null;
            this.searchBox.CustomButton.Location = new System.Drawing.Point(93, 1);
            this.searchBox.CustomButton.Name = "";
            this.searchBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchBox.CustomButton.TabIndex = 1;
            this.searchBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchBox.CustomButton.UseSelectable = true;
            this.searchBox.CustomButton.Visible = false;
            this.searchBox.Lines = new string[0];
            this.searchBox.Location = new System.Drawing.Point(759, 122);
            this.searchBox.MaxLength = 32767;
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PromptText = "Enter OrderNumber";
            this.searchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchBox.SelectedText = "";
            this.searchBox.SelectionLength = 0;
            this.searchBox.SelectionStart = 0;
            this.searchBox.ShortcutsEnabled = true;
            this.searchBox.Size = new System.Drawing.Size(115, 23);
            this.searchBox.TabIndex = 26;
            this.searchBox.UseSelectable = true;
            this.searchBox.WaterMark = "Enter OrderNumber";
            this.searchBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBox_KeyPress);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(759, 151);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 27;
            this.search.Text = "Search";
            this.search.UseSelectable = true;
            this.search.Click += new System.EventHandler(this.Search_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(533, 89);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(32, 23);
            this.next.TabIndex = 28;
            this.next.Text = ">";
            this.next.UseSelectable = true;
            this.next.Click += new System.EventHandler(this.Next_Click);
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(495, 89);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(32, 23);
            this.previous.TabIndex = 29;
            this.previous.Text = "<";
            this.previous.UseSelectable = true;
            this.previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.LightGreen;
            this.refreshBtn.Location = new System.Drawing.Point(21, 89);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 30;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseCustomBackColor = true;
            this.refreshBtn.UseSelectable = true;
            this.refreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // ViewOrdersUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.next);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.grandTotaltxt);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.OrderNumber1);
            this.Controls.Add(this.orderNumber2);
            this.Controls.Add(this.FinsihOrder);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "ViewOrdersUserControl";
            this.Size = new System.Drawing.Size(990, 617);
            this.Load += new System.EventHandler(this.ViewOrdersUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jMDDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource oRDERSBindingSource;
        private JMDDatabaseDataSet1 jMDDatabaseDataSet1;
        private JMDDatabaseDataSet1TableAdapters.ORDERSTableAdapter oRDERSTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private MetroFramework.Controls.MetroButton FinsihOrder;
        private MetroFramework.Controls.MetroLabel orderNumber2;
        private MetroFramework.Controls.MetroLabel OrderNumber1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel grandTotaltxt;
        private MetroFramework.Controls.MetroTextBox searchBox;
        private MetroFramework.Controls.MetroButton search;
        private MetroFramework.Controls.MetroButton next;
        private MetroFramework.Controls.MetroButton previous;
        private MetroFramework.Controls.MetroButton refreshBtn;
    }
}
