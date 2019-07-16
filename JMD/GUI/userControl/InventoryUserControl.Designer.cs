namespace JMD.GUI.userControl
{
    partial class InventoryUserControl
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
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ItemQUpdateTxt = new MetroFramework.Controls.MetroTextBox();
            this.updateItem = new MetroFramework.Controls.MetroButton();
            this.updateIDtxt = new MetroFramework.Controls.MetroTextBox();
            this.deleteItem = new MetroFramework.Controls.MetroButton();
            this.DeleteItemtxt = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNVENTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jMDDatabaseDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jMDDatabaseDataSet2 = new JMD.JMDDatabaseDataSet2();
            this.InsertItem = new MetroFramework.Controls.MetroButton();
            this.ItemNametxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.iNVENTORYTableAdapter = new JMD.JMDDatabaseDataSet2TableAdapters.INVENTORYTableAdapter();
            this.ItemQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.RefreshBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jMDDatabaseDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jMDDatabaseDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(520, 410);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(135, 19);
            this.metroLabel4.TabIndex = 29;
            this.metroLabel4.Text = "Update Item Quantity";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(520, 270);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 19);
            this.metroLabel3.TabIndex = 28;
            this.metroLabel3.Text = "Delete Item";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(520, 68);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 19);
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = "Insert Item";
            // 
            // ItemQUpdateTxt
            // 
            // 
            // 
            // 
            this.ItemQUpdateTxt.CustomButton.Image = null;
            this.ItemQUpdateTxt.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.ItemQUpdateTxt.CustomButton.Name = "";
            this.ItemQUpdateTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ItemQUpdateTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ItemQUpdateTxt.CustomButton.TabIndex = 1;
            this.ItemQUpdateTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ItemQUpdateTxt.CustomButton.UseSelectable = true;
            this.ItemQUpdateTxt.CustomButton.Visible = false;
            this.ItemQUpdateTxt.Lines = new string[0];
            this.ItemQUpdateTxt.Location = new System.Drawing.Point(524, 500);
            this.ItemQUpdateTxt.MaxLength = 32767;
            this.ItemQUpdateTxt.Name = "ItemQUpdateTxt";
            this.ItemQUpdateTxt.PasswordChar = '\0';
            this.ItemQUpdateTxt.PromptText = "Enter Quantity";
            this.ItemQUpdateTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ItemQUpdateTxt.SelectedText = "";
            this.ItemQUpdateTxt.SelectionLength = 0;
            this.ItemQUpdateTxt.SelectionStart = 0;
            this.ItemQUpdateTxt.ShortcutsEnabled = true;
            this.ItemQUpdateTxt.Size = new System.Drawing.Size(108, 23);
            this.ItemQUpdateTxt.TabIndex = 24;
            this.ItemQUpdateTxt.UseSelectable = true;
            this.ItemQUpdateTxt.WaterMark = "Enter Quantity";
            this.ItemQUpdateTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ItemQUpdateTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ItemQUpdateTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemQUpdateTxt_KeyPress);
            // 
            // updateItem
            // 
            this.updateItem.BackColor = System.Drawing.Color.Olive;
            this.updateItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.updateItem.Location = new System.Drawing.Point(783, 500);
            this.updateItem.Name = "updateItem";
            this.updateItem.Size = new System.Drawing.Size(75, 23);
            this.updateItem.TabIndex = 25;
            this.updateItem.Text = "Update Item";
            this.updateItem.UseCustomBackColor = true;
            this.updateItem.UseCustomForeColor = true;
            this.updateItem.UseSelectable = true;
            this.updateItem.Click += new System.EventHandler(this.UpdateItem_Click);
            // 
            // updateIDtxt
            // 
            // 
            // 
            // 
            this.updateIDtxt.CustomButton.Image = null;
            this.updateIDtxt.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.updateIDtxt.CustomButton.Name = "";
            this.updateIDtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.updateIDtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.updateIDtxt.CustomButton.TabIndex = 1;
            this.updateIDtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.updateIDtxt.CustomButton.UseSelectable = true;
            this.updateIDtxt.CustomButton.Visible = false;
            this.updateIDtxt.Lines = new string[0];
            this.updateIDtxt.Location = new System.Drawing.Point(524, 471);
            this.updateIDtxt.MaxLength = 32767;
            this.updateIDtxt.Name = "updateIDtxt";
            this.updateIDtxt.PasswordChar = '\0';
            this.updateIDtxt.PromptText = "Enter Item ID";
            this.updateIDtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.updateIDtxt.SelectedText = "";
            this.updateIDtxt.SelectionLength = 0;
            this.updateIDtxt.SelectionStart = 0;
            this.updateIDtxt.ShortcutsEnabled = true;
            this.updateIDtxt.Size = new System.Drawing.Size(108, 23);
            this.updateIDtxt.TabIndex = 23;
            this.updateIDtxt.UseSelectable = true;
            this.updateIDtxt.WaterMark = "Enter Item ID";
            this.updateIDtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.updateIDtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.updateIDtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UpdateIDtxt_KeyPress);
            // 
            // deleteItem
            // 
            this.deleteItem.BackColor = System.Drawing.Color.Red;
            this.deleteItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteItem.Location = new System.Drawing.Point(783, 311);
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(75, 23);
            this.deleteItem.TabIndex = 22;
            this.deleteItem.Text = "Delete";
            this.deleteItem.UseCustomBackColor = true;
            this.deleteItem.UseCustomForeColor = true;
            this.deleteItem.UseSelectable = true;
            this.deleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // DeleteItemtxt
            // 
            // 
            // 
            // 
            this.DeleteItemtxt.CustomButton.Image = null;
            this.DeleteItemtxt.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.DeleteItemtxt.CustomButton.Name = "";
            this.DeleteItemtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DeleteItemtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DeleteItemtxt.CustomButton.TabIndex = 1;
            this.DeleteItemtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DeleteItemtxt.CustomButton.UseSelectable = true;
            this.DeleteItemtxt.CustomButton.Visible = false;
            this.DeleteItemtxt.Lines = new string[0];
            this.DeleteItemtxt.Location = new System.Drawing.Point(520, 311);
            this.DeleteItemtxt.MaxLength = 32767;
            this.DeleteItemtxt.Name = "DeleteItemtxt";
            this.DeleteItemtxt.PasswordChar = '\0';
            this.DeleteItemtxt.PromptText = "Enter Item ID";
            this.DeleteItemtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DeleteItemtxt.SelectedText = "";
            this.DeleteItemtxt.SelectionLength = 0;
            this.DeleteItemtxt.SelectionStart = 0;
            this.DeleteItemtxt.ShortcutsEnabled = true;
            this.DeleteItemtxt.Size = new System.Drawing.Size(108, 23);
            this.DeleteItemtxt.TabIndex = 21;
            this.DeleteItemtxt.UseSelectable = true;
            this.DeleteItemtxt.WaterMark = "Enter Item ID";
            this.DeleteItemtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DeleteItemtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.DeleteItemtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeleteItemtxt_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemQuantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iNVENTORYBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(84, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(344, 505);
            this.dataGridView1.TabIndex = 26;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemQuantityDataGridViewTextBoxColumn
            // 
            this.itemQuantityDataGridViewTextBoxColumn.DataPropertyName = "ItemQuantity";
            this.itemQuantityDataGridViewTextBoxColumn.HeaderText = "ItemQuantity";
            this.itemQuantityDataGridViewTextBoxColumn.Name = "itemQuantityDataGridViewTextBoxColumn";
            this.itemQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNVENTORYBindingSource
            // 
            this.iNVENTORYBindingSource.DataMember = "INVENTORY";
            this.iNVENTORYBindingSource.DataSource = this.jMDDatabaseDataSet2BindingSource;
            // 
            // jMDDatabaseDataSet2BindingSource
            // 
            this.jMDDatabaseDataSet2BindingSource.DataSource = this.jMDDatabaseDataSet2;
            this.jMDDatabaseDataSet2BindingSource.Position = 0;
            // 
            // jMDDatabaseDataSet2
            // 
            this.jMDDatabaseDataSet2.DataSetName = "JMDDatabaseDataSet2";
            this.jMDDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InsertItem
            // 
            this.InsertItem.BackColor = System.Drawing.Color.Green;
            this.InsertItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.InsertItem.Location = new System.Drawing.Point(783, 193);
            this.InsertItem.Name = "InsertItem";
            this.InsertItem.Size = new System.Drawing.Size(75, 23);
            this.InsertItem.TabIndex = 20;
            this.InsertItem.Text = "Insert";
            this.InsertItem.UseCustomBackColor = true;
            this.InsertItem.UseCustomForeColor = true;
            this.InsertItem.UseSelectable = true;
            this.InsertItem.Click += new System.EventHandler(this.InsertItem_Click);
            // 
            // ItemNametxt
            // 
            // 
            // 
            // 
            this.ItemNametxt.CustomButton.Image = null;
            this.ItemNametxt.CustomButton.Location = new System.Drawing.Point(316, 1);
            this.ItemNametxt.CustomButton.Name = "";
            this.ItemNametxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ItemNametxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ItemNametxt.CustomButton.TabIndex = 1;
            this.ItemNametxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ItemNametxt.CustomButton.UseSelectable = true;
            this.ItemNametxt.CustomButton.Visible = false;
            this.ItemNametxt.Lines = new string[0];
            this.ItemNametxt.Location = new System.Drawing.Point(520, 111);
            this.ItemNametxt.MaxLength = 32767;
            this.ItemNametxt.Name = "ItemNametxt";
            this.ItemNametxt.PasswordChar = '\0';
            this.ItemNametxt.PromptText = "Item Name";
            this.ItemNametxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ItemNametxt.SelectedText = "";
            this.ItemNametxt.SelectionLength = 0;
            this.ItemNametxt.SelectionStart = 0;
            this.ItemNametxt.ShortcutsEnabled = true;
            this.ItemNametxt.Size = new System.Drawing.Size(338, 23);
            this.ItemNametxt.TabIndex = 17;
            this.ItemNametxt.UseSelectable = true;
            this.ItemNametxt.WaterMark = "Item Name";
            this.ItemNametxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ItemNametxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(423, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "IVENTORY";
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 517;
            this.lineShape2.X2 = 899;
            this.lineShape2.Y1 = 380;
            this.lineShape2.Y2 = 381;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(990, 617);
            this.shapeContainer1.TabIndex = 30;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 516;
            this.lineShape1.X2 = 898;
            this.lineShape1.Y1 = 241;
            this.lineShape1.Y2 = 242;
            // 
            // iNVENTORYTableAdapter
            // 
            this.iNVENTORYTableAdapter.ClearBeforeFill = true;
            // 
            // ItemQuantity
            // 
            // 
            // 
            // 
            this.ItemQuantity.CustomButton.Image = null;
            this.ItemQuantity.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.ItemQuantity.CustomButton.Name = "";
            this.ItemQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ItemQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ItemQuantity.CustomButton.TabIndex = 1;
            this.ItemQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ItemQuantity.CustomButton.UseSelectable = true;
            this.ItemQuantity.CustomButton.Visible = false;
            this.ItemQuantity.Lines = new string[0];
            this.ItemQuantity.Location = new System.Drawing.Point(520, 151);
            this.ItemQuantity.MaxLength = 32767;
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.PasswordChar = '\0';
            this.ItemQuantity.PromptText = "Item Quantity";
            this.ItemQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ItemQuantity.SelectedText = "";
            this.ItemQuantity.SelectionLength = 0;
            this.ItemQuantity.SelectionStart = 0;
            this.ItemQuantity.ShortcutsEnabled = true;
            this.ItemQuantity.Size = new System.Drawing.Size(135, 23);
            this.ItemQuantity.TabIndex = 31;
            this.ItemQuantity.UseSelectable = true;
            this.ItemQuantity.WaterMark = "Item Quantity";
            this.ItemQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ItemQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ItemQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemQuantity_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(520, 196);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(0, 0);
            this.metroLabel5.TabIndex = 32;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(520, 351);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(0, 0);
            this.metroLabel6.TabIndex = 33;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(524, 545);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(0, 0);
            this.metroLabel7.TabIndex = 34;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.LightGreen;
            this.RefreshBtn.Location = new System.Drawing.Point(84, 52);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshBtn.TabIndex = 35;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseCustomBackColor = true;
            this.RefreshBtn.UseSelectable = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // InventoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.ItemQuantity);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.ItemQUpdateTxt);
            this.Controls.Add(this.updateItem);
            this.Controls.Add(this.updateIDtxt);
            this.Controls.Add(this.deleteItem);
            this.Controls.Add(this.DeleteItemtxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.InsertItem);
            this.Controls.Add(this.ItemNametxt);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "InventoryUserControl";
            this.Size = new System.Drawing.Size(990, 617);
            this.Load += new System.EventHandler(this.InventoryUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jMDDatabaseDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jMDDatabaseDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox ItemQUpdateTxt;
        private MetroFramework.Controls.MetroButton updateItem;
        private MetroFramework.Controls.MetroTextBox updateIDtxt;
        private MetroFramework.Controls.MetroButton deleteItem;
        private MetroFramework.Controls.MetroTextBox DeleteItemtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton InsertItem;
        private MetroFramework.Controls.MetroTextBox ItemNametxt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource iNVENTORYBindingSource;
        private System.Windows.Forms.BindingSource jMDDatabaseDataSet2BindingSource;
        private JMDDatabaseDataSet2 jMDDatabaseDataSet2;
        private JMDDatabaseDataSet2TableAdapters.INVENTORYTableAdapter iNVENTORYTableAdapter;
        private MetroFramework.Controls.MetroTextBox ItemQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton RefreshBtn;
    }
}
