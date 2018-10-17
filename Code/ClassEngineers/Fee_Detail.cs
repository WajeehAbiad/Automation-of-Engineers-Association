using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ClassEngineers
{
    public class Fee_Detail:DBcon
    {
        private int Fee_Det_ID;

        public int Fee_Det_ID1
        {
            get { return Fee_Det_ID; }
            set { Fee_Det_ID = value; }
        }
        private int Fee_ID;

        public int Fee_ID1
        {
            get { return Fee_ID; }
            set { Fee_ID = value; }
        }
        private int Fee_Detail_ID;

        public int Fee_Detail_ID1
        {
            get { return Fee_Detail_ID; }
            set { Fee_Detail_ID = value; }
        }
        private int Bill_Detail;

        public int Bill_Detail1
        {
            get { return Bill_Detail; }
            set { Bill_Detail = value; }
        }
        private int Year;

        public int Year1
        {
            get { return Year; }
            set { Year = value; }
        }
        public DataTable ViewAll_Fee_Detail()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "ViewALL_Fee_Detail";
            cmd.Parameters.AddWithValue("@Year", Year);
            cmd.Parameters.AddWithValue("@Fee_ID", Fee_ID);
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
