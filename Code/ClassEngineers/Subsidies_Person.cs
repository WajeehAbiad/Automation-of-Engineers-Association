using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClassEngineers
{
    public class Subsidies_Person:DBcon
    {
        private int Sub_Per_Eng_ID;

        public int Sub_Per_Eng_ID1
        {
            get { return Sub_Per_Eng_ID; }
            set { Sub_Per_Eng_ID = value; }
        }
        private int Person_ID;

        public int Person_ID1
        {
            get { return Person_ID; }
            set { Person_ID = value; }
        }
        private int Subsidy_ID;

        public int Subsidy_ID1
        {
            get { return Subsidy_ID; }
            set { Subsidy_ID = value; }
        }
        private int Engineer_ID;

        public int Engineer_ID1
        {
            get { return Engineer_ID; }
            set { Engineer_ID = value; }
        }
        public DataTable ViewAll_Recommended_Person()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "ViewAll_Recommended_Person";
            cmd.Parameters.AddWithValue("@Engineer_ID", Engineer_ID);
            cmd.Parameters.AddWithValue("@Subsidy_ID", Subsidy_ID);
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
        public DataTable ViewAll_Subsidies_Person()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "ViewAll_Subsidies_Person";
            cmd.Parameters.AddWithValue("@Engineer_ID", Engineer_ID);
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
        public DataTable Find_Num_Subsidies_Person()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "Find_Num_Subsidies_Person";
            cmd.Parameters.AddWithValue("@Person_ID", Person_ID);
            cmd.Parameters.AddWithValue("@Subsidy_ID", Subsidy_ID);
            cmd.Parameters.AddWithValue("@Engineer_ID", Engineer_ID);
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
