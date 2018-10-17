using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassEngineers
{
    public class University:DBcon
    {
        private int University_ID;

        public int University_ID1
        {
            get { return University_ID; }
            set { University_ID = value; }
        }
        private string University_Name;

        public string University_Name1
        {
            get { return University_Name; }
            set { University_Name = value; }
        }
        private int Country_ID;

        public int Country_ID1
        {
            get { return Country_ID; }
            set { Country_ID = value; }
        }
        public string AddUniversity()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "AddUniversities";
            cmd.Parameters.AddWithValue("@University_ID", University_ID);
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
        public DataTable Find_Num_University()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "Find_Num_Universities";
            cmd.Parameters.AddWithValue("@University_Name", University_Name);
            DataTable dt=new DataTable();
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
        public string Delete_University()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "Delete_Universities";
            cmd.Parameters.AddWithValue("@University_ID", University_ID);
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
        public DataTable ViewAll_University()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "ViewAll_University";
            DataTable DT = new DataTable();
            try
            {
                con.Open();
                SqlDataReader SR = cmd.ExecuteReader();
                DT.Load(SR);
                SR.Close();
                con.Close();
                return DT;
            }
            catch (Exception e1)
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                DT.Columns.Add(e1.Message);
                return DT;
            }
        }
    }
}
