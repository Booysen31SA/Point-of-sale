using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JMD.GUI.functions;
using System.Data.SqlClient;
using System.Configuration;

namespace JMD.GUI.userControl
{
    public partial class Users : UserControl
    {

        private static Users _instance;
        UserDetailsFunctions uds = new UserDetailsFunctions();
        String connectionString; // connection string
        SqlConnection connection; // connection

        UserName name = new UserName();

        public static Users Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Users();
                }
                return _instance;
            }
        }
        public Users()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["JMD.Properties.Settings.JMDDatabaseConnectionString"].ConnectionString;
            refresh();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text.Length < 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Enter a valid user name");
                }
                else if (txtPassword.Text.Length < 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Enter a valid password");
                }
                else if (txtName.Text.Length < 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Enter a valid name");
                }
                else if (txtSurname.Text.Length < 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Enter a valid Surname");
                }
                else if (txtPhoneNumber.Text.Length < 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Enter a valid Phone number");
                }
                else
                {
                    if (name.checkUserName(txtUserName.Text) == true)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "User name Already Exist");
                    }
                    else if (uds.checkpn(txtPhoneNumber.Text) == true)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Phone Number Already Exist");
                    }
                    else
                    {
                        //insert
                        uds.insertU(txtUserName.Text, txtPassword.Text, txtName.Text, txtSurname.Text, txtPhoneNumber.Text);
                        Status.Text = "Inserted";
                        refresh();

                    }
                }

            }
            catch (Exception err)
            {
                MetroFramework.MetroMessageBox.Show(this, " " + err);
            }
        }
        public void refresh()
        {
            try
            {

                connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("refreshUsers", connection);

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                connection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(this, "Error" + e);
                }
                connection.Close();

                dataGridView1.DataSource = DS.Tables[0];
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtName.Text = "";
                txtSurname.Text = "";
                txtPhoneNumber.Text = "";
                deleteUser.Text = "";
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Error" + e);
            }
        }

        private void DeleteU_Click(object sender, EventArgs e)
        {
            if (deleteUser.Text.Length < 1)
            {
                MessageBox.Show("Fill Text Box", "Invalid");
            }
            else {
                uds.DeleteU(Convert.ToInt32(deleteUser.Text));
                Status.Text = "Deleted";
                refresh();
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
