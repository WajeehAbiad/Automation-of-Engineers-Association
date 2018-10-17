using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClassEngineers
{
    public class University_Faculty:DBcon
    {
        private int ID_Uni_Fac;

        public int ID_Uni_Fac1
        {
            get { return ID_Uni_Fac; }
            set { ID_Uni_Fac = value; }
        }
        private int University_ID;

        public int University_ID1
        {
            get { return University_ID; }
            set { University_ID = value; }
        }
        private int Faculty_ID;

        public int Faculty_ID1
        {
            get { return Faculty_ID; }
            set { Faculty_ID = value; }
        }
        public string AddUniversity_Faculty()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "AddUniversities_Faculties";
            cmd.Parameters.AddWithValue("@University_ID", University_ID);
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

        public DataTable Find_Num_University_Faculty()
        {
            DataTable DT = new DataTable();
            cmd.Parameters.Clear();
            cmd.CommandText = "Find_Num_Universities_Faculties";
            cmd.Parameters.AddWithValue("@University_ID", University_ID);
            cmd.Parameters.AddWithValue("@Faculty_ID", Faculty_ID);
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
        public string Delete_University_Faculty()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "Delete_Universities_Faculties";
            cmd.Parameters.AddWithValue("@ID_Uni_Fac", ID_Uni_Fac);
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
        public DataTable viewAll_Faculty()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "ViewAll_Faculty";
            cmd.Parameters.AddWithValue("@University_ID", University_ID);
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
