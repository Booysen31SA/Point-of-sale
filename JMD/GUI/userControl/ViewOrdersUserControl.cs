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
    public partial class ViewOrdersUserControl : UserControl
    {

        String connectionString; // connection string
        SqlConnection connection; // connection
        private int orderNumber = 1;
        buyUserControlFunctions bucf = new buyUserControlFunctions();

        private static ViewOrdersUserControl _instance;

        public static ViewOrdersUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ViewOrdersUserControl();
                }
                return _instance;
            }
        }
        public ViewOrdersUserControl()
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
                SqlCommand cmd = new SqlCommand("refreshOrder", connection);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@orderNumber", orderNumber);

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
                //MAX = DS.Tables[0].Select("Id is not null").Length;
                OrderNumber1.Text = orderNumber.ToString();
                orderNumber2.Text = orderNumber.ToString();
                grandTotaltxt.Text = "R" + bucf.gTotal(orderNumber).ToString() + " DUE";


                //insertStatus.Text = "Space Available - " + (48 - MAX).ToString();

            }
            catch (Exception e)
            {
                //MessageBox.Show(this, "Error" + e);
            }

        }

        private void FinsihOrder_Click(object sender, EventArgs e)
        {
            bucf.removeOrderNumber(Convert.ToInt32(orderNumber2.Text));
            refresh();
        }

        private void ViewOrdersUserControl_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            searchOrder();
        }

        public void searchOrder()
        {

            try
            {

                connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("refreshOrder", connection);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@orderNumber", Convert.ToInt32(searchBox.Text));

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
                //MAX = DS.Tables[0].Select("Id is not null").Length;
                OrderNumber1.Text = orderNumber.ToString();
                orderNumber2.Text = orderNumber.ToString();
                grandTotaltxt.Text = "R" + bucf.gTotal(orderNumber).ToString() + " DUE";


                //insertStatus.Text = "Space Available - " + (48 - MAX).ToString();

            }
            catch (Exception e)
            {
                //MessageBox.Show(this, "Error" + e);
            }

        }

        private void Next_Click(object sender, EventArgs e)
        {
            orderNumber++;
            refresh();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (orderNumber == 0) { }
            else
            {
                orderNumber--;
                refresh();
            }
          
        }


        //=============================================================================
        //                               KEY PRESSED ACTIONS
        //=============================================================================
        private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}

