using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassEngineers
{
    public class Engineer_Fee:DBcon
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
        private int Fee_Det_ID;

        public int Fee_Det_ID1
        {
            get { return Fee_Det_ID; }
            set { Fee_Det_ID = value; }
        }

        private int Paying_Bill;

        public int Paying_Bill1
        {
            get { return Paying_Bill; }
            set { Paying_Bill = value; }
        }
        private int Year;

        public int Year1
        {
            get { return Year; }
            set { Year = value; }
        }
        private int Fee_ID;

        public int Fee_ID1
        {
            get { return Fee_ID; }
            set { Fee_ID = value; }
        }
        public DataTable ViewAll_Engineer_Fee()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "ViewAll_Engineer_Fee";
            cmd.Parameters.AddWithValue("@Fee_ID", Fee_ID);
            cmd.Parameters.AddWithValue("@Engineer_ID", Engineer_ID);
            cmd.Parameters.AddWithValue("@Year", Year);
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
