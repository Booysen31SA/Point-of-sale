using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace JMD.GUI.userControl
{
    public partial class FoodUserControl : UserControl
    {
        String connectionString; // connection string
        SqlConnection connection; // connection
        private int MAX = 0;

        private static FoodUserControl _instance;

        public static FoodUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FoodUserControl();
                }
                return _instance;
            }
        }
        public FoodUserControl()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["JMD.Properties.Settings.JMDDatabaseConnectionString"].ConnectionString;
            refresh();
        }

       

        public void refresh()
        {
            try
            {
                updateMessage.Text = "";
                deletetxt.Text = "";
                insertStatus.Text = "";
                connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("refreshFood", connection);

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

               MAX =  DS.Tables[0].Select("Id is not null").Length;
                    
                

                insertStatus.Text = "Space Available - " + (48 - MAX).ToString();

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Error" + e);
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (MAX == 48)
            {
                MessageBox.Show("Database is Full Please Delete Some Old Recipes", "Full");
            }
            else
            {
                if (foodNametxt.Text.Length == 0 || foodPricetxt.Text.Length == 0)
                {
                    MessageBox.Show("Please Fill In the Fields", "Invalid");
                }
                else
                {
                    connection = new SqlConnection(connectionString);
                    SqlCommand cmd = new SqlCommand("InserNewFood", connection);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FoodName", foodNametxt.Text);
                    cmd.Parameters.AddWithValue("@FoodPrice", foodPricetxt.Text);


                    connection.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();

                    }
                    catch (SqlException er)
                    {
                        MessageBox.Show("Recipe Already Exits", "Error");

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(" " + err, "Error");
                    }
                    connection.Close();
                    refresh();

                    insertStatus.Text = "Inserted. Space Available - " + (48-MAX);
                    foodNametxt.Text = "";
                    foodPricetxt.Text = "";
                }
            }
        }

        private void DltFood_Click(object sender, EventArgs e)
        {
            if (DeleteFood.Text.Length == 0)
            {

            }
            else
            {
                connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("DeleteFood", connection);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", DeleteFood.Text);



                connection.Open();
                try
                {
                    cmd.ExecuteNonQuery();

                    
                }
                catch (Exception err)
                {
                    MetroFramework.MetroMessageBox.Show(this, " " + err);
                }
                connection.Close();
                refresh();
                deletetxt.Text = "Deleted";
                DeleteFood.Text = "";
            }
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (updateIDtxt.Text.Length == 0 || priceUpdateTxt.Text.Length == 0)
            {
                MessageBox.Show("Please insert valid Input", "Invalid");
            }
            else
            {
                connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("UpdatePrice", connection);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", updateIDtxt.Text);
                cmd.Parameters.AddWithValue("@FoodPrice", priceUpdateTxt.Text);


                connection.Open();
                try
                {
                    cmd.ExecuteNonQuery();


                }
                catch (Exception err)
                {
                    MetroFramework.MetroMessageBox.Show(this, " " + err);
                }
                connection.Close();
                refresh();
                updateMessage.Text = "Updated";
                updateIDtxt.Text = "";
                priceUpdateTxt.Text = "";

            }
        }

        private void FoodUserControl_Load(object sender, EventArgs e)
        {

        }

        //=============================================================================
        //                               KEY PRESSED ACTIONS
        //=============================================================================
        private void FoodPricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void DeleteFood_KeyPress(object sender, KeyPressEventArgs e)
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

        private void PriceUpdateTxt_KeyPress(object sender, KeyPressEventArgs e)
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

