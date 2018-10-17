using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClassEngineers
{
    public class Faculty:DBcon
    {
        private string Faculty_Name;

        public string Faculty_Name1
        {
            get { return Faculty_Name; }
            set { Faculty_Name = value; }
        }
        private int Faculty_ID;

        public int Faculty_ID1
        {
            get { return Faculty_ID; }
            set { Faculty_ID = value; }
        }
        public string AddFaculty()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "AddFaculty";
            cmd.Parameters.AddWithValue("@Faculty_Name", Faculty_Name);

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
        public DataTable Find_Num_Faculty()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "Find_Num_Faculty";
            cmd.Parameters.AddWithValue("@Faculty_Name", Faculty_Name);

            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataReader SR = cmd.ExecuteReader();
                dt.Load(SR);
                SR.Close();
                con.Close();
                return dt;
            }
            catch (Exception e1)
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                dt.Columns.Add(e1.Message);
                return dt;
            }


        }
        public string Delete_Faculty()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "Delete_Faculty";
            cmd.Parameters.AddWithValue("@Faculty_ID", Faculty_ID);
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
        public string Find_Faculty()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "Find_Faculty";
            cmd.Parameters.AddWithValue("@Faculty_ID", Faculty_ID);
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
