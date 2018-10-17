using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassEngineers
{
    public class subsidies_Bill:DBcon
    {
        private int ID;

        public int ID1
        {
            get { return ID; }
            set { ID = value; }
        }
        private int Sub_Per_Eng_ID;

        public int Sub_Per_Eng_ID1
        {
            get { return Sub_Per_Eng_ID; }
            set { Sub_Per_Eng_ID = value; }
        }
        private int Engineer_ID;

        public int Engineer_ID1
        {
            get { return Engineer_ID; }
            set { Engineer_ID = value; }
        }
        private int Recieving_Bill;

        public int Recieving_Bill1
        {
            get { return Recieving_Bill; }
            set { Recieving_Bill = value; }
        }
        private int Document_ID;

        public int Document_ID1
        {
            get { return Document_ID; }
            set { Document_ID = value; }
        }
        private DateTime Document_Date;

        public DateTime Document_Date1
        {
            get { return Document_Date; }
            set { Document_Date = value; }
        }
        private int Decision_ID;

        public int Decision_ID1
        {
            get { return Decision_ID; }
            set { Decision_ID = value; }
        }
        private int Subsidy_ID;

        public int Subsidy_ID1
        {
            get { return Subsidy_ID; }
            set { Subsidy_ID = value; }
        }
        private int Person_ID;

        public int Person_ID1
        {
            get { return Person_ID; }
            set { Person_ID = value; }
        }
        public DataTable ViewAll_Subsidies_Bill()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "ViewAll_Subsidies_Bills";
            cmd.Parameters.AddWithValue("@Subsidy_ID", Subsidy_ID);
            cmd.Parameters.AddWithValue("@Engineer_ID", Engineer_ID);
            cmd.Parameters.AddWithValue("@Person_ID", Person_ID);
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
