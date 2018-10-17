using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using ClassEngineers;

namespace WpfApplication4
{
    /// <summary>
    /// Interaction logic for DataLoad.xaml
    /// </summary>
    public partial class DataLoad : Window
    {
        University u = new University();
        University_Faculty uf = new University_Faculty(); 
          

        public DataLoad()
        {
            InitializeComponent();
            List<string> items = new List<string>();
            items.Add("Male");
            items.Add("Female");
            comboBox_Sex.ItemsSource = items;

            List<string> Semester = new List<string>();
            Semester.Add("First");
            Semester.Add("Second");
            Semester.Add("Third");
            comboBox_Semester.ItemsSource = Semester;
            List<string> university = new List<string>();
            DataTable dt=u.ViewAll_University();
            DataRow DR;
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                DR = dt.Rows[i];
                university.Add(DR.ItemArray[0].ToString());
            }
            comboBox_University.ItemsSource = university;

        }

        
        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Qualifications_Click(object sender, RoutedEventArgs e)
        {
            int Engineer_ID = Convert.ToInt32(textBox_EngineerID.Text);
           Qualifications Qualifications_Form = new Qualifications(Engineer_ID);
            
            Qualifications_Form.Show();

        }     

        private void Button_Degrees_Click(object sender, RoutedEventArgs e)
        {
            int Engineer_ID = Convert.ToInt32(textBox_EngineerID.Text);
            Degrees Degrees_Form = new Degrees(Engineer_ID);
            Degrees_Form.Show();
        }

        private void Button_Recommended_pepole_Click(object sender, RoutedEventArgs e)
        {
            int Engineer_ID = Convert.ToInt32(textBox_EngineerID.Text);
            Recommended_pepole Recommended_pepole_Form = new Recommended_pepole(Engineer_ID);
            Recommended_pepole_Form.Show();
        }

        private void Button_Trainers_Click(object sender, RoutedEventArgs e)
        {
            int Engineer_ID = Convert.ToInt32(textBox_EngineerID.Text);
            Coaches Coaches_Form = new Coaches(Engineer_ID);
            Coaches_Form.Show();
        }

        private void Button_Fees_Click(object sender, RoutedEventArgs e)
        {
            int Engineer_ID = Convert.ToInt32(textBox_EngineerID.Text);
            fees Fees_Form = new fees(Engineer_ID);
            Fees_Form.Show();
        }

        private void Button_Subsidies_Bills_Click(object sender, RoutedEventArgs e)
        {
            int Engineer_ID = Convert.ToInt32(textBox_EngineerID.Text);
            Subsidies_Bills Subsidies_Bills_Form = new Subsidies_Bills(Engineer_ID);
            Subsidies_Bills_Form.Show();
        }

        private void Button_Add_Engineer_Click(object sender, RoutedEventArgs e)
        {
            if (Button_Add_Engineer.Content == "Add Engineer")
            {
                
                Engineer_Personality EP = new Engineer_Personality();
                EP.Engineer_ID1 =Convert.ToInt32( textBox_EngineerID.Text);
                EP.First_Name1 = textBox_First_Name.Text;
                EP.Last_Name1 = textBox_Last_Name.Text;
                EP.Father_Name1 = textBox_Father_Name.Text;
                EP.Mather_Name1 = textBox_Mother_Name.Text;
                EP.Place_of_Birth1 = textBox_Place_of_Birth.Text;              
                EP.Date_of_Birth1 = Convert.ToDateTime(DatePicker_Death_Date.Text); ;
                EP.National_Number1 = Convert .ToDouble(textBox_Nation_Number.Text);
                EP.Sex1 = comboBox_Sex.Text;
                EP.Nationality1 = textBox_Nationality.Text;
                EP.Mobile_Number1 =Convert.ToInt32( textBox_Mobile_Number.Text);
                EP.E_Mail1 = textBox_E_Mail.Text;
                EP.University1 = comboBox_University.Text;
                EP.Year_of_Study1 =Convert.ToInt32( textBox_Year_of_Study.Text);
                EP.Semester1 =comboBox_Semester.Text;
                EP.Section1 = textBox_Section.Text;
                try
                { EP.Date_of_Eretirement1 = Convert.ToDateTime(DatePicker_Retirement_Date.Text); }
                catch
                {

                    EP.Date_of_Eretirement1 = null;
                }
                try
                {
                    EP.Date_of_Death1 = Convert.ToDateTime(DatePicker_Death_Date);
                }
                catch
                {
                    EP.Date_of_Death1 = null;
                }
                if (checkBox_Idintity_Card.IsChecked == true)
                {
                    EP.Receiving_Identity_Card1 = true;
                }
                else
                    EP.Receiving_Identity_Card1 = false;
                if (checkBox_Oath.IsChecked == true)
                {
                    EP.Oath_Interpretation1 = true;

                }
                else
                    EP.Oath_Interpretation1 =false;
                EP.Moved_From1 = textBox_Moved_From.Text;
                EP.License1 = comboBox_License.Text;
                EP.Specialization1 = comboBox_Specialization.Text;
                EP.AddEngineer();
               
                for (int i = 1; i <= 3; i++)
                {
                    Engineer_Address EA = new Engineer_Address();
                    EA.Address_ID1 = i;

                    if (i == 2)
                    {
                        EA.The_Ward1 = textBox_Area_Work.Text;
                        EA.The_Street1 = textBox_Street_Work.Text;
                        EA.Phone1 = Convert.ToInt32(textBox_Phone_Work.Text);
                        EA.Extra_nformation1 = textBox_Extra_Info_Work.Text;
                        EA.Engineer_ID1 = Convert.ToInt32(textBox_EngineerID.Text);
                        EA.The_City1 = "Aleppo";
                    }
                    else if (i == 1)
                    {
                        EA.The_Ward1 = textBox_Area_Temporary_Living.Text;
                        EA.The_Street1 = textBox_Street_Temporary_Living.Text;
                        EA.Phone1 = Convert.ToInt32(textBox_Phone_Temporary_Living.Text);
                        EA.Extra_nformation1 = textBox_Extra_Info_Temporary_Living.Text;
                        EA.Engineer_ID1 = Convert.ToInt32(textBox_EngineerID.Text);
                        EA.The_City1 = "Aleppo";
                    }
                    else if (i == 3)
                    {
                        EA.The_Ward1 = textBox__Area_Permanent_Living.Text;
                        EA.The_Street1 = textBox_Permanent_Living.Text;
                        EA.Phone1 = Convert.ToInt32(textBox_Phone_Permanent_Living.Text);
                        EA.Extra_nformation1 = textBox_Extra_Info_Permanent_Living.Text;
                        EA.Engineer_ID1 = Convert.ToInt32(textBox_EngineerID.Text);
                        EA.The_City1 = "Aleppo";
                    }



                }
                
            }
            else
                if (Button_Add_Engineer.Content == "Update Engineer")
                {
                    Engineer_Personality EP = new Engineer_Personality();
                    EP.Engineer_ID1 = Convert.ToInt32(textBox_EngineerID.Text);
                    EP.First_Name1 = textBox_First_Name.Text;
                    EP.Last_Name1 = textBox_Last_Name.Text;
                    EP.Father_Name1 = textBox_Father_Name.Text;
                    EP.Mather_Name1 = textBox_Mother_Name.Text;
                    EP.Place_of_Birth1 = textBox_Place_of_Birth.Text;
                    EP.Date_of_Birth1 =Convert.ToDateTime( DatePicker_Date_of_Birth.Text);
                    EP.National_Number1 = Convert.ToDouble(textBox_Nation_Number.Text);
                    EP.Sex1 = comboBox_Sex.Text;
                    EP.Nationality1 = textBox_Nationality.Text;
                    EP.Mobile_Number1 = Convert.ToInt32(textBox_Mobile_Number.Text);
                    EP.E_Mail1 = textBox_E_Mail.Text;
                    EP.University1 = comboBox_University.Text;
                    EP.Year_of_Study1 = Convert.ToInt32(textBox_Year_of_Study.Text);
                    EP.Semester1 = comboBox_Semester.Text;
                    EP.Section1 = textBox_Section.Text;
                    try
                    { EP.Date_of_Eretirement1 = Convert.ToDateTime(DatePicker_Retirement_Date.Text); }
                    catch
                    {

                        EP.Date_of_Eretirement1 = null;
                    }
                    try
                    {
                        EP.Date_of_Death1 = Convert.ToDateTime(DatePicker_Death_Date);
                    }
                    catch
                    {
                        EP.Date_of_Death1 = null;
                    }
                    
                    if (checkBox_Idintity_Card.IsChecked == true)
                    {
                        EP.Receiving_Identity_Card1 = true;
                    }
                    else
                        EP.Receiving_Identity_Card1 = false;
                    if (checkBox_Oath.IsChecked == true)
                    {
                        EP.Oath_Interpretation1 = true;

                    }
                    else
                        EP.Oath_Interpretation1 = false;
                    EP.Moved_From1 = textBox_Moved_From.Text;
                    EP.License1 = comboBox_License.Text;
                    EP.Specialization1 = comboBox_Specialization.Text;
                   string s= EP.UpEngineer();
                   for (int i = 1; i <= 3; i++)
                   {
                       Engineer_Address EA = new Engineer_Address();                      
                       EA.Address_ID1 = i;
                           
                           if (i == 2)
                           {
                              EA.The_Ward1= textBox_Area_Work.Text; 
                              EA.The_Street1= textBox_Street_Work.Text;
                              EA.Phone1=Convert.ToInt32( textBox_Phone_Work.Text);
                              EA.Extra_nformation1= textBox_Extra_Info_Work.Text;
                              EA.Engineer_ID1=Convert.ToInt32( textBox_EngineerID.Text);
                              EA.The_City1="Aleppo";
                           }
                           else if (i == 1)
                           {
                              EA.The_Ward1= textBox_Area_Temporary_Living.Text;
                              EA.The_Street1= textBox_Street_Temporary_Living.Text;
                              EA.Phone1=Convert.ToInt32( textBox_Phone_Temporary_Living.Text);
                              EA.Extra_nformation1= textBox_Extra_Info_Temporary_Living.Text;
                              EA.Engineer_ID1=Convert.ToInt32(textBox_EngineerID.Text);
                              EA.The_City1="Aleppo";
                           }
                           else if (i == 3)
                           {
                              EA.The_Ward1= textBox__Area_Permanent_Living.Text;
                              EA.The_Street1= textBox_Permanent_Living.Text;
                              EA.Phone1=Convert.ToInt32( textBox_Phone_Permanent_Living.Text);
                              EA.Extra_nformation1= textBox_Extra_Info_Permanent_Living.Text;
                              EA.Engineer_ID1=Convert.ToInt32(textBox_EngineerID.Text);
                              EA.The_City1="Aleppo";
                           }



                       }
                   }

                
        }
       public void Faculty_Specialization()
        {

        }

       private void comboBox_Specialization_SelectionChanged(object sender, SelectionChangedEventArgs e)
       {

       }
         
       private void comboBox_University_SelectionChanged(object sender, SelectionChangedEventArgs e)
       {

           u.University_Name1 = comboBox_University.SelectedValue.ToString();
           DataTable dt1 = u.Find_Num_University();
           DataRow dr;
           DataTable dt = new DataTable();
           List<string> Faculty = new List<string>();
           for (int i = 0; i < dt1.Rows.Count; i++)
           {
               dr= dt1.Rows[i];
                           
               uf.University_ID1 =Convert.ToInt32( dr.ItemArray[0].ToString());
               dt = uf.viewAll_Faculty();
           }
           DataRow DR;
           for (int i = 0; i < dt.Rows.Count; i++)
           {

               DR = dt.Rows[i];
               Faculty.Add(DR.ItemArray[0].ToString());
           }
           comboBox_License.ItemsSource = Faculty;
           
      }
       private void comboBox_Section_SelectionChanged(object sender, SelectionChangedEventArgs e)
       {
           u.University_Name1 = comboBox_University.SelectedValue.ToString();
           DataTable dt1 = u.Find_Num_University();
           DataRow dr;     
           for (int i = 0; i < dt1.Rows.Count; i++)
           {
               dr = dt1.Rows[i];
               uf.University_ID1 = Convert.ToInt32(dr.ItemArray[0].ToString());              
           }
           Faculty f = new Faculty();
           f.Faculty_Name1 = comboBox_License.SelectedValue.ToString();
           DataTable dt = f.Find_Num_Faculty();
           DataRow dr1;
           for (int i = 0; i < dt.Rows.Count; i++)
           {
               dr1 = dt.Rows[i];
               uf.Faculty_ID1 = Convert.ToInt32(dr1.ItemArray[0].ToString());
           }
           DataTable dt2 = uf.Find_Num_University_Faculty();
           DataRow dr2;
           University_Faculty_Specialization ufs = new University_Faculty_Specialization();
           for (int i = 0; i < dt2.Rows.Count; i++)
           {
               dr2 = dt2.Rows[i];
               ufs.ID_Uni_Fac1 = Convert.ToInt32(dr2.ItemArray[0].ToString());
           }
           DataTable dt3= ufs.Name_of_Specialization();
           List<string> Specialization = new List<string>();
           for (int i = 0; i < dt3.Rows.Count; i++)
           {
               dr2 = dt3.Rows[i];
               Specialization.Add(dr2.ItemArray[0].ToString());
           }
           comboBox_Specialization.ItemsSource = Specialization;
           
       }

 

    }
    }
