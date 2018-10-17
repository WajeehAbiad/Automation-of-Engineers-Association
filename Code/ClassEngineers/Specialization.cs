using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClassEngineers
{
    public class Specialization:DBcon
    {
        private int Specialization_ID;

        public int Specialization_ID1
        {
            get { return Specialization_ID; }
            set { Specialization_ID = value; }
        }
        private string Specialization_Name;

        public string Specialization_Name1
        {
            get { return Specialization_Name; }
            set { Specialization_Name = value; }
        }
        public string AddSpecialization()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "AddSpecialization";
            cmd.Parameters.AddWithValue("@Specialization_Name", Specialization_Name);

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
        public int Find_Num_Specialization()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "Find_Num_Specialization";
            cmd.Parameters.AddWithValue("@Specialization_Name", Specialization_Name);

            con.Open();
            int result = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();
            return result;


        }
        public string Delete_Specialization()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "Delete_Specialization";
            cmd.Parameters.AddWithValue("@Specialization_ID", Specialization_ID);
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
        public string Find_Specialization()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "Find_Specialization";
            cmd.Parameters.AddWithValue("@Specialization_ID", Specialization_ID);
            try
            {
                con.Open();
                string result = cmd.ExecuteScalar().ToString();
                con.Close();
                return result;
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
    }
}
