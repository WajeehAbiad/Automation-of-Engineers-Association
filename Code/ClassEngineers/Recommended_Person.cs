using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassEngineers
{
    public class Recommended_Person:DBcon
    {
        private int Person_ID;

        public int Person_ID1
        {
            get { return Person_ID; }
            set { Person_ID = value; }
        }
        private string Person_Name;

        public string Person_Name1
        {
            get { return Person_Name; }
            set { Person_Name = value; }
        }
        public DataTable Find_Num_Recommended_Person()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "Find_Num_Recommended_Person";
            cmd.Parameters.AddWithValue("@Person_Name", Person_Name);
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
