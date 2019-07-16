using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMD.GUI.functions


{
    class buyUserControlFunctions
    {
        String connectionString; // connection string
        SqlConnection connection; // connection

        //=============================================================================
        //                                  INSERT
        //=============================================================================
        public void insertOrder(String food, int quantity, int price, int orderNumber)
        {
            connectionString = ConfigurationManager.ConnectionStrings["JMD.Properties.Settings.JMDDatabaseConnectionString"].ConnectionString;

            connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("InsertNewOrder", connection);
            SqlCommand cmdAll = new SqlCommand("insertAllOrders", connection);

            cmd.CommandType = CommandType.StoredProcedure;
            cmdAll.CommandType = CommandType.StoredProcedure; 

            int total = (Convert.ToInt32(quantity) * (Convert.ToInt32(price)));

            cmd.Parameters.AddWithValue("@FoodType", food);
            cmd.Parameters.AddWithValue("@Quantity", quantity);
            cmd.Parameters.AddWithValue("@Total", total);
            cmd.Parameters.AddWithValue("@orderNumber", orderNumber);

            cmdAll.Parameters.AddWithValue("@FoodType", food);
            cmdAll.Parameters.AddWithValue("@Quantity", quantity);
            cmdAll.Parameters.AddWithValue("@Total", total);
            cmdAll.Parameters.AddWithValue("@orderNumber", orderNumber);

            connection.Open();
            try
            {
                cmd.ExecuteNonQuery();
                cmdAll.ExecuteNonQuery();

            }
            catch (SqlException er)
            {
                MessageBox.Show(er + "");

            }
            catch (Exception err)
            {
                MessageBox.Show(" " + err, "Error");
            }
            connection.Close();

        }
        //=============================================================================
        //                                  Get Price
        //=============================================================================
        public int price(String food)
        {
            connectionString = ConfigurationManager.ConnectionStrings["JMD.Properties.Settings.JMDDatabaseConnectionString"].ConnectionString;

            connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("getPrice", connection);

            cmd.CommandType = CommandType.StoredProcedure;

           

            cmd.Parameters.AddWithValue("@FoodName", food);

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            connection.Open();
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (SqlException er)
            {
                MessageBox.Show(er + "");

            }
            catch (Exception err)
            {
                MessageBox.Show(" " + err, "Error");
            }
            connection.Close();
            int price = Convert.ToInt32(DS.Tables[0].Rows[0]["FoodPrice"].ToString());
            return price;
        }
        //=============================================================================
        //                                  get Highest Number
        //=============================================================================
        public int highestNumber()
        {
            connectionString = ConfigurationManager.ConnectionStrings["JMD.Properties.Settings.JMDDatabaseConnectionString"].ConnectionString;

            connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("maxOrderNumber", connection);

            cmd.CommandType = CommandType.StoredProcedure;


            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            connection.Open();
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (SqlException er)
            {
                MessageBox.Show(er + "");

            }
            catch (Exception err)
            {
                MessageBox.Show(" " + err, "Error");
            }
            connection.Close();
            int max = 0;

            int listSize;
            bool success = int.TryParse(DS.Tables[0].Rows[0]["orderNumber"].ToString(), out listSize);
            if (success)
            {
                max = Convert.ToInt32(DS.Tables[0].Rows[0]["orderNumber"].ToString()); ;
            }
            max++;
            return max;
        }
        //=============================================================================
        //                                  Get Grand Total
        //=============================================================================
        public int gTotal(int orderNumber)
        {
            connectionString = ConfigurationManager.ConnectionStrings["JMD.Properties.Settings.JMDDatabaseConnectionString"].ConnectionString;

            connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("grandTotal", connection);

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
            catch (SqlException er)
            {
                MessageBox.Show(er + "");

            }
            catch (Exception err)
            {
                MessageBox.Show(" " + err, "Error");
            }
            connection.Close();
            int sum = 0;

            int listSize;
            bool success = int.TryParse(DS.Tables[0].Rows[0]["grand"].ToString(), out listSize);
            if (success)
            {
                sum = Convert.ToInt32(DS.Tables[0].Rows[0]["grand"].ToString()); ;
            }
            
            return sum;
        }
        //=============================================================================
        //                                  Remove by orderID
        //=============================================================================
        public void removeOrderID(int orderID)
        {
            connectionString = ConfigurationManager.ConnectionStrings["JMD.Properties.Settings.JMDDatabaseConnectionString"].ConnectionString;

            connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("removeOrderID", connection);

            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@orderID", orderID);

            connection.Open();
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (SqlException er)
            {
                MessageBox.Show(er + "");

            }
            catch (Exception err)
            {
                MessageBox.Show(" " + err, "Error");
            }
            connection.Close();
        }

        //=============================================================================
        //                                  Remove by OrderNumber
        //=============================================================================
        public void removeOrderNumber(int orderNumber)
        {
            connectionString = ConfigurationManager.ConnectionStrings["JMD.Properties.Settings.JMDDatabaseConnectionString"].ConnectionString;

            connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("removeOrderNumber", connection);

            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@orderNumber", orderNumber);

            connection.Open();
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (SqlException er)
            {
                MessageBox.Show(er + "");

            }
            catch (Exception err)
            {
                MessageBox.Show(" " + err, "Error");
            }
            connection.Close();
        }
    }




}
