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
    class UserDetailsFunctions
    {
        private String connectionString; // connection string
        private SqlConnection connection; // connection

        //=============================================================================
        //                                  CheckPhoneNumber
        //=============================================================================
        public bool checkpn(String number)
        {
            return checkPhoneNumber(number);
        }
        private bool checkPhoneNumber(String n)
        {
            Boolean value = false;
            try
            {
                connectionString = ConfigurationManager.ConnectionStrings["JMD.Properties.Settings.JMDDatabaseConnectionString"].ConnectionString;

                String query = "SELECT userPhoneNumber FROM UserDetails WHERE userPhoneNumber = '" + n + "'";

                connection = new SqlConnection(connectionString);
                SqlDataReader dr;
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                dr = cmd.ExecuteReader();

                dr.Read();
                if (dr[0].ToString().Equals(n))
                {
                    value = true;
                }

#pragma warning disable CS0168 // The variable 'err' is declared but never used
            }
            catch (Exception err)
#pragma warning restore CS0168 // The variable 'err' is declared but never used
            {

            }

            connection.Close();
            return value;
        }
        //=============================================================================
        //                                  INSERT
        //=============================================================================
        public void insertU(String uname, String pw, String name, String surname, String num)
        {
            insert(uname, pw, name, surname, num);

        }
        private void insert(String uname, String pw, String name, String surname, String num)
        {
            connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("InserNewUser", connection);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@userName", uname);
            cmd.Parameters.AddWithValue("@userPassword", pw);
            cmd.Parameters.AddWithValue("@userFName", name);
            cmd.Parameters.AddWithValue("@userLName", surname);
            cmd.Parameters.AddWithValue("@userPhoneNumber", num);

            connection.Open();
            try
            {
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err + "", "Error");
            }
            connection.Close();
        }

        //=============================================================================
        //                                  DELETE
        //=============================================================================
        public void DeleteU(int ID)
        {
            DeleteUser(ID);
        }
        private void DeleteUser(int ID)
        {
            connectionString = ConfigurationManager.ConnectionStrings["JMD.Properties.Settings.JMDDatabaseConnectionString"].ConnectionString;

            connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("DeleteUser", connection);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", ID);



            connection.Open();
            try
            {
                cmd.ExecuteNonQuery();


            }
            catch (SqlException er)
            {
                MessageBox.Show("Item Name Possible Already Exist in Database");

            }
            catch (Exception err)
            {
                MessageBox.Show(" " + err, "Error");
            }
            connection.Close();
        }
    }
}
