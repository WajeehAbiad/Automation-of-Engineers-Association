using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClassEngineers
{
    public class Engineer_Qualification:DBcon
    {
        private string darg;

        public string Darg
        {
            get { return darg; }
            set { darg = value; }
        }
        private int Qualification_ID;

        public int Qualification_ID1
        {
            get { return Qualification_ID; }
            set { Qualification_ID = value; }
        }
        private int Engineer_ID;

        public int Engineer_ID1
        {
            get { return Engineer_ID; }
            set { Engineer_ID = value; }
        }
        private DateTime Date_of_Qualification_Obtainment;

        public DateTime Date_of_Qualification_Obtainment1
        {
            get { return Date_of_Qualification_Obtainment; }
            set { Date_of_Qualification_Obtainment = value; }
        }
        private int ID_Uni_Fac_Spe;

        public int ID_Uni_Fac_Spe1
        {
            get { return ID_Uni_Fac_Spe; }
            set { ID_Uni_Fac_Spe = value; }
        }
        private bool Qualification_Used;

        public bool Qualification_Used1
        {
            get { return Qualification_Used; }
            set { Qualification_Used = value; }
        }
        public string AddEngineer_Qualification()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "AddEngineer_Qualification";
            cmd.Parameters.AddWithValue("@Qualification_ID", Qualification_ID);
            cmd.Parameters.AddWithValue("@Engineer_ID", Engineer_ID);
            cmd.Parameters.AddWithValue("@Date_of_Qualification_Obtaiment", Date_of_Qualification_Obtainment);
            cmd.Parameters.AddWithValue("@ID_Uni_Fac_Spe", ID_Uni_Fac_Spe);
            cmd.Parameters.AddWithValue("@Qualification_Used", Qualification_Used);
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
                    con.Close();
                return e1.Message;
            }
        }
        public string UpEngineer_Qualification()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "UpEngineer_Qualification";
            cmd.Parameters.AddWithValue("@Qualification_ID", Qualification_ID);
            cmd.Parameters.AddWithValue("@Engineer_ID", Engineer_ID);
            cmd.Parameters.AddWithValue("@Qualification_Used", Qualification_Used);
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
                    con.Close();
                return e1.Message;
            }
        }

        public DataTable FindEngineer_Qualification()
        {
            DataTable DT = new DataTable();
            cmd.Parameters.Clear();
            cmd.CommandText = "FindEngineer_Qualification";
            cmd.Parameters.AddWithValue("@Engineer_ID", Engineer_ID);
            cmd.Parameters.AddWithValue("@Qualification_ID", Qualification_ID);

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
        public DataTable ViewAll_Engineer_Qualification()
        {
            DataTable DT = new DataTable();
            cmd.Parameters.Clear();
            cmd.CommandText = "ViewAll_Engineer_Qualification";
            cmd.Parameters.AddWithValue("@Engineer_ID", Engineer_ID);

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
