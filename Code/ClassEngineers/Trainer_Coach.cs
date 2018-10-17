using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassEngineers
{
    public class Trainer_Coach:DBcon
    {
        private int ID;

        public int ID1
        {
            get { return ID; }
            set { ID = value; }
        }
        private int ID_Trainer;

        public int ID_Trainer1
        {
            get { return ID_Trainer; }
            set { ID_Trainer = value; }
        }
        private int ID_Coach;

        public int ID_Coach1
        {
            get { return ID_Coach; }
            set { ID_Coach = value; }
        }
        private DateTime From_Date;

        public DateTime From_Date1
        {
            get { return From_Date; }
            set { From_Date = value; }
        }
        private DateTime To_Date;

        public DateTime To_Date1
        {
            get { return To_Date; }
            set { To_Date = value; }
        }
        private string Extra_Information;

        public string Extra_Information1
        {
            get { return Extra_Information; }
            set { Extra_Information = value; }
        }
        public DataTable ViewAll_Trainer()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "ViewAll_Trainer";
            cmd.Parameters.AddWithValue("@ID_Coach", ID_Coach);
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
        public DataTable ViewAll_Coach()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "ViewAll_Coach";
            cmd.Parameters.AddWithValue("@ID_Trainer", ID_Trainer);
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
