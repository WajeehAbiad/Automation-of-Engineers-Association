using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClassEngineers
{
    public class Country:DBcon
    {
        private int Country_ID;

        public int Country_ID1
        {
            get { return Country_ID; }
            set { Country_ID = value; }
        }
        private string Country_Name;

        public string Country_Name1
        {
            get { return Country_Name; }
            set { Country_Name = value; }
        }
        public string AddCountry()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "AddCountry";
            cmd.Parameters.AddWithValue("@Country_Name", Country_Name);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return " ";
            }
            catch (Exception e1)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return e1.Message;
            }
        }
        public int Find_Num_Country()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "Find_Num_Country";
            cmd.Parameters.AddWithValue("@Country_Name", Country_Name);

            con.Open();
            int result = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();
            return result;


        }
        public string Delete_Country()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "Delete_Country";
            cmd.Parameters.AddWithValue("@Country_ID", Country_ID);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return " ";
            }
            catch (Exception e1)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return e1.Message;
            }

        }
        public string Find_Country()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "Find_Country";
            cmd.Parameters.AddWithValue("@Country_ID", Country_ID);
            try
            {
                con.Open();
                string result = cmd.ExecuteScalar().ToString();
                con.Close();
                return result;
            }
            catch (Exception e1)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return e1.Message;
            }
        }
    }
}
