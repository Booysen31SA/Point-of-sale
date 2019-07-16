namespace JMD.GUI.userControl
{
    partial class Users
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jMDDatabaseDataSet3 = new JMD.JMDDatabaseDataSet3();
            this.userDetailTableAdapter = new JMD.JMDDatabaseDataSet3TableAdapters.UserDetailTableAdapter();
            this.registerBtn = new MetroFramework.Controls.MetroButton();
            this.txtPhoneNumber = new MetroFramework.Controls.MetroTextBox();
            this.txtSurname = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.Status = new MetroFramework.Controls.MetroLabel();
            this.deleteUser = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.DeleteU = new MetroFramework.Controls.MetroButton();
            this.RefreshBtn = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jMDDatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.userPasswordDataGridViewTextBoxColumn,
            this.userFNameDataGridViewTextBoxColumn,
            this.userLNameDataGridViewTextBoxColumn,
            this.userPhoneNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userDetailBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(195, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(643, 160);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "userName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "userName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userPasswordDataGridViewTextBoxColumn
            // 
            this.userPasswordDataGridViewTextBoxColumn.DataPropertyName = "userPassword";
            this.userPasswordDataGridViewTextBoxColumn.HeaderText = "userPassword";
            this.userPasswordDataGridViewTextBoxColumn.Name = "userPasswordDataGridViewTextBoxColumn";
            this.userPasswordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userFNameDataGridViewTextBoxColumn
            // 
            this.userFNameDataGridViewTextBoxColumn.DataPropertyName = "userFName";
            this.userFNameDataGridViewTextBoxColumn.HeaderText = "userFName";
            this.userFNameDataGridViewTextBoxColumn.Name = "userFNameDataGridViewTextBoxColumn";
            this.userFNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userLNameDataGridViewTextBoxColumn
            // 
            this.userLNameDataGridViewTextBoxColumn.DataPropertyName = "userLName";
            this.userLNameDataGridViewTextBoxColumn.HeaderText = "userLName";
            this.userLNameDataGridViewTextBoxColumn.Name = "userLNameDataGridViewTextBoxColumn";
            this.userLNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userPhoneNumberDataGridViewTextBoxColumn
            // 
            this.userPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "userPhoneNumber";
            this.userPhoneNumberDataGridViewTextBoxColumn.HeaderText = "userPhoneNumber";
            this.userPhoneNumberDataGridViewTextBoxColumn.Name = "userPhoneNumberDataGridViewTextBoxColumn";
            this.userPhoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userDetailBindingSource
            // 
            this.userDetailBindingSource.DataMember = "UserDetail";
            this.userDetailBindingSource.DataSource = this.jMDDatabaseDataSet3;
            // 
            // jMDDatabaseDataSet3
            // 
            this.jMDDatabaseDataSet3.DataSetName = "JMDDatabaseDataSet3";
            this.jMDDatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userDetailTableAdapter
            // 
            this.userDetailTableAdapter.ClearBeforeFill = true;
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.Green;
            this.registerBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.registerBtn.Location = new System.Drawing.Point(226, 531);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(100, 30);
            this.registerBtn.Style = MetroFramework.MetroColorStyle.Orange;
            this.registerBtn.TabIndex = 14;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseCustomBackColor = true;
            this.registerBtn.UseCustomForeColor = true;
            this.registerBtn.UseSelectable = true;
            this.registerBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // txtPhoneNumber
            // 
            // 
            // 
            // 
            this.txtPhoneNumber.CustomButton.Image = null;
            this.txtPhoneNumber.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtPhoneNumber.CustomButton.Name = "";
            this.txtPhoneNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhoneNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.txtPhoneNumber.CustomButton.TabIndex = 1;
            this.txtPhoneNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhoneNumber.CustomButton.UseSelectable = true;
            this.txtPhoneNumber.CustomButton.Visible = false;
            this.txtPhoneNumber.Lines = new string[0];
            this.txtPhoneNumber.Location = new System.Drawing.Point(195, 471);
            this.txtPhoneNumber.MaxLength = 32767;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PromptText = "Enter Phone Number ...";
            this.txtPhoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.SelectionLength = 0;
            this.txtPhoneNumber.SelectionStart = 0;
            this.txtPhoneNumber.ShortcutsEnabled = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(166, 23);
            this.txtPhoneNumber.TabIndex = 13;
            this.txtPhoneNumber.UseSelectable = true;
            this.txtPhoneNumber.WaterMark = "Enter Phone Number ...";
            this.txtPhoneNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhoneNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSurname
            // 
            // 
            // 
            // 
            this.txtSurname.CustomButton.Image = null;
            this.txtSurname.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtSurname.CustomButton.Name = "";
            this.txtSurname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.txtSurname.CustomButton.TabIndex = 1;
            this.txtSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSurname.CustomButton.UseSelectable = true;
            this.txtSurname.CustomButton.Visible = false;
            this.txtSurname.Lines = new string[0];
            this.txtSurname.Location = new System.Drawing.Point(195, 433);
            this.txtSurname.MaxLength = 32767;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.PasswordChar = '\0';
            this.txtSurname.PromptText = "Enter Surname ...";
            this.txtSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSurname.SelectedText = "";
            this.txtSurname.SelectionLength = 0;
            this.txtSurname.SelectionStart = 0;
            this.txtSurname.ShortcutsEnabled = true;
            this.txtSurname.Size = new System.Drawing.Size(166, 23);
            this.txtSurname.TabIndex = 12;
            this.txtSurname.UseSelectable = true;
            this.txtSurname.WaterMark = "Enter Surname ...";
            this.txtSurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(195, 395);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Enter First Name ...";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(166, 23);
            this.txtName.TabIndex = 11;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Enter First Name ...";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(195, 357);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PromptText = "Enter Password ...";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(166, 23);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Enter Password ...";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.CustomButton.Image = null;
            this.txtUserName.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtUserName.CustomButton.Name = "";
            this.txtUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.txtUserName.CustomButton.TabIndex = 1;
            this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.CustomButton.UseSelectable = true;
            this.txtUserName.CustomButton.Visible = false;
            this.txtUserName.Lines = new string[0];
            this.txtUserName.Location = new System.Drawing.Point(195, 317);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PromptText = "Enter User name ...";
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShortcutsEnabled = true;
            this.txtUserName.Size = new System.Drawing.Size(166, 23);
            this.txtUserName.TabIndex = 9;
            this.txtUserName.UseSelectable = true;
            this.txtUserName.WaterMark = "Enter User name ...";
            this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(195, 212);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 0);
            this.Status.TabIndex = 16;
            // 
            // deleteUser
            // 
            // 
            // 
            // 
            this.deleteUser.CustomButton.Image = null;
            this.deleteUser.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.deleteUser.CustomButton.Name = "";
            this.deleteUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.deleteUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.deleteUser.CustomButton.TabIndex = 1;
            this.deleteUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.deleteUser.CustomButton.UseSelectable = true;
            this.deleteUser.CustomButton.Visible = false;
            this.deleteUser.Lines = new string[0];
            this.deleteUser.Location = new System.Drawing.Point(551, 317);
            this.deleteUser.MaxLength = 32767;
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.PasswordChar = '\0';
            this.deleteUser.PromptText = "Enter user ID";
            this.deleteUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.deleteUser.SelectedText = "";
            this.deleteUser.SelectionLength = 0;
            this.deleteUser.SelectionStart = 0;
            this.deleteUser.ShortcutsEnabled = true;
            this.deleteUser.Size = new System.Drawing.Size(102, 23);
            this.deleteUser.TabIndex = 17;
            this.deleteUser.UseSelectable = true;
            this.deleteUser.WaterMark = "Enter user ID";
            this.deleteUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.deleteUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(195, 269);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Insert User";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(551, 269);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "Delete User";
            // 
            // DeleteU
            // 
            this.DeleteU.BackColor = System.Drawing.Color.Red;
            this.DeleteU.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteU.Location = new System.Drawing.Point(551, 531);
            this.DeleteU.Name = "DeleteU";
            this.DeleteU.Size = new System.Drawing.Size(100, 30);
            this.DeleteU.Style = MetroFramework.MetroColorStyle.Orange;
            this.DeleteU.TabIndex = 20;
            this.DeleteU.Text = "Delete";
            this.DeleteU.UseCustomBackColor = true;
            this.DeleteU.UseCustomForeColor = true;
            this.DeleteU.UseSelectable = true;
            this.DeleteU.Click += new System.EventHandler(this.DeleteU_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.LightGreen;
            this.RefreshBtn.Location = new System.Drawing.Point(195, 20);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshBtn.TabIndex = 21;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseCustomBackColor = true;
            this.RefreshBtn.UseSelectable = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JMD.Properties.Resources.Password_See;
            this.pictureBox1.Location = new System.Drawing.Point(380, 357);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 23);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.DeleteU);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Users";
            this.Size = new System.Drawing.Size(990, 617);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jMDDatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userDetailBindingSource;
        private JMDDatabaseDataSet3 jMDDatabaseDataSet3;
        private JMDDatabaseDataSet3TableAdapters.UserDetailTableAdapter userDetailTableAdapter;
        private MetroFramework.Controls.MetroButton registerBtn;
        private MetroFramework.Controls.MetroTextBox txtPhoneNumber;
        private MetroFramework.Controls.MetroTextBox txtSurname;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtUserName;
        private MetroFramework.Controls.MetroLabel Status;
        private MetroFramework.Controls.MetroTextBox deleteUser;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton DeleteU;
        private MetroFramework.Controls.MetroButton RefreshBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
