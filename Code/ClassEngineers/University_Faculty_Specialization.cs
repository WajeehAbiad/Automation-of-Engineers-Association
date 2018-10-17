using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClassEngineers
{
    public class University_Faculty_Specialization:DBcon
    {
        private int ID_Uni_Fac_Spe;

        public int ID_Uni_Fac_Spe1
        {
            get { return ID_Uni_Fac_Spe; }
            set { ID_Uni_Fac_Spe = value; }
        }
        private int Specialization_ID;

        public int Specialization_ID1
        {
            get { return Specialization_ID; }
            set { Specialization_ID = value; }
        }
        private int ID_Uni_Fac;

        public int ID_Uni_Fac1
        {
            get { return ID_Uni_Fac; }
            set { ID_Uni_Fac = value; }
        }
        public string AddUniversity_Faculty_Specialization()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "AddUniversities_Faculties_Specializations";
            cmd.Parameters.AddWithValue("@Specialization_ID", Specialization_ID);
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
        public string Delete_University_Faculty_Specialization()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "Delete_Universities_Faculties_Specializations";
            cmd.Parameters.AddWithValue("@ID_Uni_Fac_Spe", ID_Uni_Fac_Spe);
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

        public DataTable Find_Num_University_Faculty_Specialization()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "Find_Num_Universities_Faculties_Specializations";
            cmd.Parameters.AddWithValue("@Specialization_ID", Specialization_ID);
            cmd.Parameters.AddWithValue("@ID_Uni_Fac", ID_Uni_Fac);

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
        public DataTable Find_University_Faculty_Specialization()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "FindUnivesities_Faculties_Specializations";
            cmd.Parameters.AddWithValue("@ID_Uni_Fac_Spe", ID_Uni_Fac_Spe);
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
        public DataTable View_University_Faculty_Specialization()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "ViewAll_Univesities_Faculties_Specializations";

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
        public DataTable Name_of_Specialization()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "Name_of_Specialization";
            cmd.Parameters.AddWithValue("@ID_Uni_Fac", ID_Uni_Fac);
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
