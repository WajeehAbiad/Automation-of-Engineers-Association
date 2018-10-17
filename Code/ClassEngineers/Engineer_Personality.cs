using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClassEngineers
{
    public class Engineer_Personality:DBcon
    {
        private int Engineer_ID;

        public int Engineer_ID1
        {
            get { return Engineer_ID; }
            set { Engineer_ID = value; }
        }
        private string First_Name;

        public string First_Name1
        {
            get { return First_Name; }
            set { First_Name = value; }
        }
        private string Last_Name;

        public string Last_Name1
        {
            get { return Last_Name; }
            set { Last_Name = value; }
        }
        private string Father_Name;

        public string Father_Name1
        {
            get { return Father_Name; }
            set { Father_Name = value; }
        }
        private string Mother_Name;

        public string Mather_Name1
        {
            get { return Mother_Name; }
            set { Mother_Name = value; }
        }
        private string Place_of_Birth;

        public string Place_of_Birth1
        {
            get { return Place_of_Birth; }
            set { Place_of_Birth = value; }
        }
        private DateTime Date_of_Birth;

        public DateTime Date_of_Birth1
        {
            get { return Date_of_Birth; }
            set { Date_of_Birth = value; }
        }
        private double National_Number;

        public double National_Number1
        {
            get { return National_Number; }
            set { National_Number = value; }
        }
        private string Sex;

        public string Sex1
        {
            get { return Sex; }
            set { Sex = value; }
        }
        private string Nationality;

        public string Nationality1
        {
            get { return Nationality; }
            set { Nationality = value; }
        }
        private double Mobile_Number;

        public double Mobile_Number1
        {
            get { return Mobile_Number; }
            set { Mobile_Number = value; }
        }
        private string E_Mail;

        public string E_Mail1
        {
            get { return E_Mail; }
            set { E_Mail = value; }
        }
        private string University;

        public string University1
        {
            get { return University; }
            set { University = value; }
        }
        private int Year_of_Study;

        public int Year_of_Study1
        {
            get { return Year_of_Study; }
            set { Year_of_Study = value; }
        }
        private string Semester;

        public string Semester1
        {
            get { return Semester; }
            set { Semester = value; }
        }
        private string License;

        public string License1
        {
            get { return License; }
            set { License = value; }
        }
        private DateTime? Date_of_Eretirement;
        
        public DateTime? Date_of_Eretirement1
        {
            get { return Date_of_Eretirement; }
            set { Date_of_Eretirement = value; }
        }
        private   DateTime? Date_of_Death;

        public DateTime? Date_of_Death1
        {
            get { return Date_of_Death; }
            set { Date_of_Death = value; }
        }
        private bool Receiving_Identity_Card;

        public bool Receiving_Identity_Card1
        {
            get { return Receiving_Identity_Card; }
            set { Receiving_Identity_Card = value; }
        }
        private bool Oath_Interpretation;

        public bool Oath_Interpretation1
        {
            get { return Oath_Interpretation; }
            set { Oath_Interpretation = value; }
        }
        private string Moved_From;

        public string Moved_From1
        {
            get { return Moved_From; }
            set { Moved_From = value; }
        }
        private string Section;

        public string Section1
        {
            get { return Section; }
            set { Section = value; }
        }
        private string Specialization;

        public string Specialization1
        {
            get { return Specialization; }
            set { Specialization = value; }
        }
        public string AddEngineer()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "AddEngineer";
            cmd.Parameters.AddWithValue("@Engineer_ID", Engineer_ID);
            cmd.Parameters.AddWithValue("@First_Name", First_Name);
            cmd.Parameters.AddWithValue("@Last_Name", Last_Name);
            cmd.Parameters.AddWithValue("@Father_Name", Father_Name);
            cmd.Parameters.AddWithValue("@Mother_Name", Mother_Name);
            cmd.Parameters.AddWithValue("@Place_of_Birth", Place_of_Birth);
            cmd.Parameters.AddWithValue("@Date_of_Birth", Date_of_Birth);
            cmd.Parameters.AddWithValue("@National_Number", National_Number);
            cmd.Parameters.AddWithValue("@Sex", Sex);
            cmd.Parameters.AddWithValue("@Nationality", Nationality);
            cmd.Parameters.AddWithValue("@Mobile_Number", Mobile_Number);
            cmd.Parameters.AddWithValue("@E_mail", E_Mail);
            cmd.Parameters.AddWithValue("@University", University);
            cmd.Parameters.AddWithValue("@Year_of_Study", Year_of_Study);
            cmd.Parameters.AddWithValue("@Semester", Semester);
            cmd.Parameters.AddWithValue("@License", License);
            cmd.Parameters.AddWithValue("@Date_of_Eretirement", Date_of_Eretirement);
            cmd.Parameters.AddWithValue("@Date_of_Death", Date_of_Death);
            cmd.Parameters.AddWithValue("@Receiving_Identity_Card", Receiving_Identity_Card);
            cmd.Parameters.AddWithValue("@Oath_Interpretation", Oath_Interpretation);
            cmd.Parameters.AddWithValue("@Moved_From", Moved_From);
            cmd.Parameters.AddWithValue("@Section", Section);
            cmd.Parameters.AddWithValue("@Specialization", Specialization);
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
        public string UpEngineer()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "UpEngineer";
            cmd.Parameters.AddWithValue("@Engineer_ID", Engineer_ID);
            cmd.Parameters.AddWithValue("@First_Name", First_Name);
            cmd.Parameters.AddWithValue("@Last_Name", Last_Name);
            cmd.Parameters.AddWithValue("@Father_Name", Father_Name);
            cmd.Parameters.AddWithValue("@Mother_Name", Mother_Name);
            cmd.Parameters.AddWithValue("@Place_of_Birth", Place_of_Birth);
            cmd.Parameters.AddWithValue("@Date_of_Birth", Date_of_Birth);
            cmd.Parameters.AddWithValue("@National_Number", National_Number);
            cmd.Parameters.AddWithValue("@Sex", Sex);
            cmd.Parameters.AddWithValue("@Nationality", Nationality);
            cmd.Parameters.AddWithValue("@Mobile_Number", Mobile_Number);
            cmd.Parameters.AddWithValue("@E_mail", E_Mail);
            cmd.Parameters.AddWithValue("@University", University);
            cmd.Parameters.AddWithValue("@Year_of_Study", Year_of_Study);
            cmd.Parameters.AddWithValue("@Semester", Semester);
            cmd.Parameters.AddWithValue("@License", License);
            cmd.Parameters.AddWithValue("@Date_of_Eretirement", Date_of_Eretirement);
            cmd.Parameters.AddWithValue("@Date_of_Death", Date_of_Death);
            cmd.Parameters.AddWithValue("@Receiving_Identity_Card", Receiving_Identity_Card);
            cmd.Parameters.AddWithValue("@Oath_Interpretation", Oath_Interpretation);
            cmd.Parameters.AddWithValue("@Moved_From", Moved_From);
            cmd.Parameters.AddWithValue("@Section", Section);
            cmd.Parameters.AddWithValue("@Specialization", Specialization);
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
        public DataTable FindEngineer()
        {
            DataTable DT = new DataTable();
            cmd.Parameters.Clear();
            cmd.CommandText = "FindEngineer";
            cmd.Parameters.AddWithValue("@Engineer_ID", Engineer_ID);

         //   try
          //  {
                con.Open();
                SqlDataReader SR = cmd.ExecuteReader();
                DT.Load(SR);
                SR.Close();
                con.Close();
                return DT;
          //  }
            //catch (Exception e1)
            //{
            //    if (con.State == ConnectionState.Open)
            //        con.Close();
            //    DT.Columns.Add(e1.Message);
            //    return DT;
            //}
        }
    }
}
