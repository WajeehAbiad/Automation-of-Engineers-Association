using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClassEngineers
{
    public class Address:DBcon
    {
        
        private int Address_ID;

        public int Address_ID1
        {
            get { return Address_ID; }
            set { Address_ID = value; }
        }
        private string Address_Type;

        public string Address_Type1
        {
            get { return Address_Type; }
            set { Address_Type = value; }
        }
        public string AddAddress()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "AddAddress";
            cmd.Parameters.AddWithValue("@Address_Name", Address_Type);

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
        public int Find_Num_Address()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "Find_Num_Address";
            cmd.Parameters.AddWithValue("@Address_Name", Address_Type);

            con.Open();
            int result = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();
            return result;


        }
        public string Delete_Address()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "Delete_Address";
            cmd.Parameters.AddWithValue("@Address_ID", Address_ID);
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
        public string Find_Address()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "Find_Address";
            cmd.Parameters.AddWithValue("@Address_ID", Address_ID);
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
