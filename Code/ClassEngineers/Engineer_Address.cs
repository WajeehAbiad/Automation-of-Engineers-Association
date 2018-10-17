using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ClassEngineers
{
    public class Engineer_Address:DBcon
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
        private int Address_ID;

        public int Address_ID1
        {
            get { return Address_ID; }
            set { Address_ID = value; }
        }
        private string The_City;

        public string The_City1
        {
            get { return The_City; }
            set { The_City = value; }
        }
        private string The_Ward;

        public string The_Ward1
        {
            get { return The_Ward; }
            set { The_Ward = value; }
        }
        private string The_Street;

        public string The_Street1
        {
            get { return The_Street; }
            set { The_Street = value; }
        }
        private double Phone;

        public double Phone1
        {
            get { return Phone; }
            set { Phone = value; }
        }
        private string Extra_nformation;

        public string Extra_nformation1
        {
            get { return Extra_nformation; }
            set { Extra_nformation = value; }
        }
        public string AddEngineer_Address()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "AddEngineer_Address";
            cmd.Parameters.AddWithValue("@Engineer_ID", Engineer_ID);
            cmd.Parameters.AddWithValue("@Address_ID", Address_ID);
            cmd.Parameters.AddWithValue("@The_City", The_City);
            cmd.Parameters.AddWithValue("@The_Ward", The_Ward);
            cmd.Parameters.AddWithValue("@The_Street", The_Street);
            cmd.Parameters.AddWithValue("Phone", Phone);
            cmd.Parameters.AddWithValue("Extra_Information", Extra_nformation);
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
        public DataTable Find_Engineer_Address()
        {
            DataTable DT = new DataTable();
            cmd.Parameters.Clear();
            cmd.CommandText = "Find_Engineer_Address";
            cmd.Parameters.AddWithValue("@Engineer_ID", Engineer_ID);
            cmd.Parameters.AddWithValue("@Address_ID", Address_ID);
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
