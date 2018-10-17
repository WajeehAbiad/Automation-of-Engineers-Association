using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassEngineers
{
    public class Engineer_Degree:DBcon
    {
        private int ID;

        public int ID1
        {
            get { return ID; }
            set { ID = value; }
        }
        private int Engineer_ID;

        public int Engineer_ID1
        {
            get { return Engineer_ID; }
            set { Engineer_ID = value; }
        }
        private int Degree_ID;

        public int Degree_ID1
        {
            get { return Degree_ID; }
            set { Degree_ID = value; }
        }
        private DateTime Date_of_Request;

        public DateTime Date_of_Request1
        {
            get { return Date_of_Request; }
            set { Date_of_Request = value; }
        }
        private int Decision_Number;

        public int Decision_Number1
        {
            get { return Decision_Number; }
            set { Decision_Number = value; }
        }
        private DateTime Date_of_Decision_Approval;

        public DateTime Date_of_Decision_Approval1
        {
            get { return Date_of_Decision_Approval; }
            set { Date_of_Decision_Approval = value; }
        }
        private DateTime Date_of_Engineer_Approval;

        public DateTime Date_of_Engineer_Approval1
        {
            get { return Date_of_Engineer_Approval; }
            set { Date_of_Engineer_Approval = value; }
        }
        public DataTable ViewAll_Engineer_Degree()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "ViewAll_Engineer_Degree";
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
