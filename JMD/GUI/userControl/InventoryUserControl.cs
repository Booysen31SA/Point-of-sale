using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using JMD.GUI.functions;

namespace JMD.GUI.userControl
{
    public partial class InventoryUserControl : UserControl
    {
        String connectionString; // connection string
        SqlConnection connection; // connection
        InventoryFunctions inf = new InventoryFunctions();

        private static InventoryUserControl _instance;

        public static InventoryUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new InventoryUserControl();
                }
                return _instance;
            }
        }
        public InventoryUserControl()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["JMD.Properties.Settings.JMDDatabaseConnectionString"].ConnectionString;
            refresh();
        }

        public void refresh()
        {
            try
            {
                
                connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("refreshInventory", connection);

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
                metroLabel5.Text = "";
                metroLabel6.Text = "";
                metroLabel7.Text = "";

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Error" + e);
            }
        }

        private void InsertItem_Click(object sender, EventArgs e)
        {
            inf.InsertPass(ItemNametxt.Text, Convert.ToInt32(ItemQuantity.Text));
            refresh();
            metroLabel5.Text = "Inserted";
            ItemNametxt.Text = "";
            ItemQuantity.Text = "";
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            inf.DeletePass(Convert.ToInt32(DeleteItemtxt.Text));
            refresh();
            metroLabel6.Text = "Update";
            DeleteItemtxt.Text = "";
        }

        private void UpdateItem_Click(object sender, EventArgs e)
        {
            inf.UpdatePass(Convert.ToInt32(updateIDtxt.Text), Convert.ToInt32(ItemQUpdateTxt.Text));
            refresh();
            metroLabel7.Text = "Updated";
            updateIDtxt.Text = "";
            ItemQUpdateTxt.Text = "";
        }


        //=============================================================================
        //                               KEY PRESSED ACTIONS
        //=============================================================================
        private void ItemQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void DeleteItemtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void UpdateIDtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void ItemQUpdateTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void InventoryUserControl_Load(object sender, EventArgs e)
        {

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}

