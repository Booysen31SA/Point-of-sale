namespace JMD.GUI.userControl
{
    partial class FoodUserControl
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
            this.jMDDatabaseDataSet = new JMD.JMDDatabaseDataSet();
            this.foodTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodTableTableAdapter = new JMD.JMDDatabaseDataSetTableAdapters.FoodTableTableAdapter();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.foodNametxt = new MetroFramework.Controls.MetroTextBox();
            this.foodPricetxt = new MetroFramework.Controls.MetroTextBox();
            this.Insert = new MetroFramework.Controls.MetroButton();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.insertStatus = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteFood = new MetroFramework.Controls.MetroTextBox();
            this.foodTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dltFood = new MetroFramework.Controls.MetroButton();
            this.updateIDtxt = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.priceUpdateTxt = new MetroFramework.Controls.MetroTextBox();
            this.updateMessage = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.deletetxt = new MetroFramework.Controls.MetroLabel();
            this.refreshBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.jMDDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // jMDDatabaseDataSet
            // 
            this.jMDDatabaseDataSet.DataSetName = "JMDDatabaseDataSet";
            this.jMDDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodTableBindingSource
            // 
            this.foodTableBindingSource.DataMember = "FoodTable";
            this.foodTableBindingSource.DataSource = this.jMDDatabaseDataSet;
            // 
            // foodTableTableAdapter
            // 
            this.foodTableTableAdapter.ClearBeforeFill = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(367, 44);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "FOOD TO MAKE";
            // 
            // foodNametxt
            // 
            // 
            // 
            // 
            this.foodNametxt.CustomButton.Image = null;
            this.foodNametxt.CustomButton.Location = new System.Drawing.Point(365, 1);
            this.foodNametxt.CustomButton.Name = "";
            this.foodNametxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.foodNametxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.foodNametxt.CustomButton.TabIndex = 1;
            this.foodNametxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.foodNametxt.CustomButton.UseSelectable = true;
            this.foodNametxt.CustomButton.Visible = false;
            this.foodNametxt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.foodTableBindingSource, "FoodName", true));
            this.foodNametxt.Lines = new string[0];
            this.foodNametxt.Location = new System.Drawing.Point(464, 124);
            this.foodNametxt.MaxLength = 32767;
            this.foodNametxt.Name = "foodNametxt";
            this.foodNametxt.PasswordChar = '\0';
            this.foodNametxt.PromptText = "Food Name";
            this.foodNametxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.foodNametxt.SelectedText = "";
            this.foodNametxt.SelectionLength = 0;
            this.foodNametxt.SelectionStart = 0;
            this.foodNametxt.ShortcutsEnabled = true;
            this.foodNametxt.Size = new System.Drawing.Size(387, 23);
            this.foodNametxt.TabIndex = 0;
            this.foodNametxt.UseSelectable = true;
            this.foodNametxt.WaterMark = "Food Name";
            this.foodNametxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.foodNametxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // foodPricetxt
            // 
            // 
            // 
            // 
            this.foodPricetxt.CustomButton.Image = null;
            this.foodPricetxt.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.foodPricetxt.CustomButton.Name = "";
            this.foodPricetxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.foodPricetxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.foodPricetxt.CustomButton.TabIndex = 1;
            this.foodPricetxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.foodPricetxt.CustomButton.UseSelectable = true;
            this.foodPricetxt.CustomButton.Visible = false;
            this.foodPricetxt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.foodTableBindingSource, "FoodPrice", true));
            this.foodPricetxt.Lines = new string[0];
            this.foodPricetxt.Location = new System.Drawing.Point(464, 165);
            this.foodPricetxt.MaxLength = 32767;
            this.foodPricetxt.Name = "foodPricetxt";
            this.foodPricetxt.PasswordChar = '\0';
            this.foodPricetxt.PromptText = "Food Price";
            this.foodPricetxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.foodPricetxt.SelectedText = "";
            this.foodPricetxt.SelectionLength = 0;
            this.foodPricetxt.SelectionStart = 0;
            this.foodPricetxt.ShortcutsEnabled = true;
            this.foodPricetxt.Size = new System.Drawing.Size(108, 23);
            this.foodPricetxt.TabIndex = 1;
            this.foodPricetxt.UseSelectable = true;
            this.foodPricetxt.WaterMark = "Food Price";
            this.foodPricetxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.foodPricetxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.foodPricetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FoodPricetxt_KeyPress);
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.Color.Green;
            this.Insert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Insert.Location = new System.Drawing.Point(727, 212);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 2;
            this.Insert.Text = "Insert";
            this.Insert.UseCustomBackColor = true;
            this.Insert.UseCustomForeColor = true;
            this.Insert.UseSelectable = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
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
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 464;
            this.lineShape2.X2 = 846;
            this.lineShape2.Y1 = 372;
            this.lineShape2.Y2 = 373;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 469;
            this.lineShape1.X2 = 851;
            this.lineShape1.Y1 = 255;
            this.lineShape1.Y2 = 256;
            // 
            // insertStatus
            // 
            this.insertStatus.AutoSize = true;
            this.insertStatus.Location = new System.Drawing.Point(464, 212);
            this.insertStatus.Name = "insertStatus";
            this.insertStatus.Size = new System.Drawing.Size(0, 0);
            this.insertStatus.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.foodNameDataGridViewTextBoxColumn,
            this.foodPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.foodTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(344, 505);
            this.dataGridView1.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // foodNameDataGridViewTextBoxColumn
            // 
            this.foodNameDataGridViewTextBoxColumn.DataPropertyName = "FoodName";
            this.foodNameDataGridViewTextBoxColumn.HeaderText = "FoodName";
            this.foodNameDataGridViewTextBoxColumn.Name = "foodNameDataGridViewTextBoxColumn";
            this.foodNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // foodPriceDataGridViewTextBoxColumn
            // 
            this.foodPriceDataGridViewTextBoxColumn.DataPropertyName = "FoodPrice";
            this.foodPriceDataGridViewTextBoxColumn.HeaderText = "FoodPrice";
            this.foodPriceDataGridViewTextBoxColumn.Name = "foodPriceDataGridViewTextBoxColumn";
            this.foodPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DeleteFood
            // 
            // 
            // 
            // 
            this.DeleteFood.CustomButton.Image = null;
            this.DeleteFood.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.DeleteFood.CustomButton.Name = "";
            this.DeleteFood.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DeleteFood.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DeleteFood.CustomButton.TabIndex = 1;
            this.DeleteFood.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DeleteFood.CustomButton.UseSelectable = true;
            this.DeleteFood.CustomButton.Visible = false;
            this.DeleteFood.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.foodTableBindingSource, "Id", true));
            this.DeleteFood.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodTableBindingSource1, "Id", true));
            this.DeleteFood.Lines = new string[0];
            this.DeleteFood.Location = new System.Drawing.Point(464, 314);
            this.DeleteFood.MaxLength = 32767;
            this.DeleteFood.Name = "DeleteFood";
            this.DeleteFood.PasswordChar = '\0';
            this.DeleteFood.PromptText = "Enter Food ID";
            this.DeleteFood.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DeleteFood.SelectedText = "";
            this.DeleteFood.SelectionLength = 0;
            this.DeleteFood.SelectionStart = 0;
            this.DeleteFood.ShortcutsEnabled = true;
            this.DeleteFood.Size = new System.Drawing.Size(108, 23);
            this.DeleteFood.TabIndex = 3;
            this.DeleteFood.UseSelectable = true;
            this.DeleteFood.WaterMark = "Enter Food ID";
            this.DeleteFood.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DeleteFood.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.DeleteFood.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeleteFood_KeyPress);
            // 
            // foodTableBindingSource1
            // 
            this.foodTableBindingSource1.DataMember = "FoodTable";
            this.foodTableBindingSource1.DataSource = this.jMDDatabaseDataSet;
            // 
            // dltFood
            // 
            this.dltFood.BackColor = System.Drawing.Color.Red;
            this.dltFood.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dltFood.Location = new System.Drawing.Point(727, 314);
            this.dltFood.Name = "dltFood";
            this.dltFood.Size = new System.Drawing.Size(75, 23);
            this.dltFood.TabIndex = 4;
            this.dltFood.Text = "Delete";
            this.dltFood.UseCustomBackColor = true;
            this.dltFood.UseCustomForeColor = true;
            this.dltFood.UseSelectable = true;
            this.dltFood.Click += new System.EventHandler(this.DltFood_Click);
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
            this.updateIDtxt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.foodTableBindingSource, "Id", true));
            this.updateIDtxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodTableBindingSource1, "Id", true));
            this.updateIDtxt.Lines = new string[0];
            this.updateIDtxt.Location = new System.Drawing.Point(468, 438);
            this.updateIDtxt.MaxLength = 32767;
            this.updateIDtxt.Name = "updateIDtxt";
            this.updateIDtxt.PasswordChar = '\0';
            this.updateIDtxt.PromptText = "Enter Food ID";
            this.updateIDtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.updateIDtxt.SelectedText = "";
            this.updateIDtxt.SelectionLength = 0;
            this.updateIDtxt.SelectionStart = 0;
            this.updateIDtxt.ShortcutsEnabled = true;
            this.updateIDtxt.Size = new System.Drawing.Size(108, 23);
            this.updateIDtxt.TabIndex = 5;
            this.updateIDtxt.UseSelectable = true;
            this.updateIDtxt.WaterMark = "Enter Food ID";
            this.updateIDtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.updateIDtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.updateIDtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UpdateIDtxt_KeyPress);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Olive;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.metroButton1.Location = new System.Drawing.Point(727, 480);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Update Price";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // priceUpdateTxt
            // 
            // 
            // 
            // 
            this.priceUpdateTxt.CustomButton.Image = null;
            this.priceUpdateTxt.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.priceUpdateTxt.CustomButton.Name = "";
            this.priceUpdateTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.priceUpdateTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.priceUpdateTxt.CustomButton.TabIndex = 1;
            this.priceUpdateTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.priceUpdateTxt.CustomButton.UseSelectable = true;
            this.priceUpdateTxt.CustomButton.Visible = false;
            this.priceUpdateTxt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.foodTableBindingSource, "Id", true));
            this.priceUpdateTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodTableBindingSource1, "Id", true));
            this.priceUpdateTxt.Lines = new string[0];
            this.priceUpdateTxt.Location = new System.Drawing.Point(468, 480);
            this.priceUpdateTxt.MaxLength = 32767;
            this.priceUpdateTxt.Name = "priceUpdateTxt";
            this.priceUpdateTxt.PasswordChar = '\0';
            this.priceUpdateTxt.PromptText = "Enter Price";
            this.priceUpdateTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.priceUpdateTxt.SelectedText = "";
            this.priceUpdateTxt.SelectionLength = 0;
            this.priceUpdateTxt.SelectionStart = 0;
            this.priceUpdateTxt.ShortcutsEnabled = true;
            this.priceUpdateTxt.Size = new System.Drawing.Size(108, 23);
            this.priceUpdateTxt.TabIndex = 6;
            this.priceUpdateTxt.UseSelectable = true;
            this.priceUpdateTxt.WaterMark = "Enter Price";
            this.priceUpdateTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.priceUpdateTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.priceUpdateTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceUpdateTxt_KeyPress);
            // 
            // updateMessage
            // 
            this.updateMessage.AutoSize = true;
            this.updateMessage.Location = new System.Drawing.Point(468, 527);
            this.updateMessage.Name = "updateMessage";
            this.updateMessage.Size = new System.Drawing.Size(0, 0);
            this.updateMessage.TabIndex = 13;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(464, 81);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Insert Food";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(464, 275);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(81, 19);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Delete Food";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(464, 385);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(120, 19);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Update Food Price";
            // 
            // deletetxt
            // 
            this.deletetxt.AutoSize = true;
            this.deletetxt.Location = new System.Drawing.Point(464, 344);
            this.deletetxt.Name = "deletetxt";
            this.deletetxt.Size = new System.Drawing.Size(0, 0);
            this.deletetxt.TabIndex = 17;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.LightGreen;
            this.refreshBtn.Location = new System.Drawing.Point(28, 65);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 18;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseCustomBackColor = true;
            this.refreshBtn.UseSelectable = true;
            this.refreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // FoodUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.deletetxt);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.updateMessage);
            this.Controls.Add(this.priceUpdateTxt);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.updateIDtxt);
            this.Controls.Add(this.dltFood);
            this.Controls.Add(this.DeleteFood);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.insertStatus);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.foodPricetxt);
            this.Controls.Add(this.foodNametxt);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "FoodUserControl";
            this.Size = new System.Drawing.Size(990, 617);
            this.Load += new System.EventHandler(this.FoodUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jMDDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodTableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource foodTableBindingSource;
        private JMDDatabaseDataSet jMDDatabaseDataSet;
        private JMDDatabaseDataSetTableAdapters.FoodTableTableAdapter foodTableTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox foodNametxt;
        private MetroFramework.Controls.MetroTextBox foodPricetxt;
        private MetroFramework.Controls.MetroButton Insert;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private MetroFramework.Controls.MetroLabel insertStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodPriceDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTextBox DeleteFood;
        private MetroFramework.Controls.MetroButton dltFood;
        private System.Windows.Forms.BindingSource foodTableBindingSource1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private MetroFramework.Controls.MetroTextBox updateIDtxt;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox priceUpdateTxt;
        private MetroFramework.Controls.MetroLabel updateMessage;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel deletetxt;
        private MetroFramework.Controls.MetroButton refreshBtn;
    }
}
