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
using System.Data;
using System.Data.SqlClient;
using ClassEngineers;

namespace WpfApplication4
{
    /// <summary>
    /// Interaction logic for Engineers_View.xaml
    /// </summary>
    public partial class Engineers_View : Window
    {
        public static SqlConnection Connection = new SqlConnection("Data Source=asus;Initial Catalog=Engineers;Integrated Security=True");
        public static SqlDataAdapter DataAdapter;
        public static DataSet _DataSet;
        Engineer_Personality EP = new Engineer_Personality();
        public static DataTable GetData(string SelectStatement)
        {
            DataAdapter = new SqlDataAdapter(SelectStatement, Connection);
            _DataSet = new DataSet();
            DataAdapter.Fill(_DataSet);
            return _DataSet.Tables[0];


        }

        public Engineers_View()
        {
            InitializeComponent();
            dataGrid.ItemsSource = Engineers_View.GetData("Select Engineer_ID , First_Name , Last_Name , Father_Name , Mother_Name , Mobile_Number from Engineer_Personality").DefaultView;
        }

        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_View_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                DataRowView row = (DataRowView)dataGrid.SelectedItems[0];
                DataLoad DataLoad_Form = new DataLoad();
                EP.Engineer_ID1 = Convert.ToInt32(row[0].ToString());
                DataTable DT = EP.FindEngineer();
                DataRow DR;
                for (int i = 0; i < DT.Rows.Count; i++)
                {

                    DR = DT.Rows[i];

                    DataLoad_Form.textBox_EngineerID.Text = DR.ItemArray[0].ToString();
                    DataLoad_Form.textBox_First_Name.Text = DR.ItemArray[1].ToString();
                    DataLoad_Form.textBox_Last_Name.Text = DR.ItemArray[2].ToString();
                    DataLoad_Form.textBox_Father_Name.Text = DR.ItemArray[3].ToString();
                    DataLoad_Form.textBox_Mother_Name.Text = DR.ItemArray[4].ToString();
                    DataLoad_Form.textBox_Place_of_Birth.Text = DR.ItemArray[5].ToString();
                    DataLoad_Form.DatePicker_Date_of_Birth.Text = (Convert.ToDateTime(DR.ItemArray[6]).ToShortDateString());
                    DataLoad_Form.textBox_Nation_Number.Text = DR.ItemArray[7].ToString();
                    DataLoad_Form.comboBox_Sex.Text = DR.ItemArray[8].ToString();
                    DataLoad_Form.textBox_Nationality.Text = DR.ItemArray[9].ToString();
                    DataLoad_Form.textBox_Mobile_Number.Text = "0" + DR.ItemArray[10].ToString();
                    DataLoad_Form.textBox_E_Mail.Text = DR.ItemArray[11].ToString();
                    DataLoad_Form.comboBox_University.Text = DR.ItemArray[12].ToString();
                    DataLoad_Form.comboBox_University.Text = DR.ItemArray[12].ToString();
                    DataLoad_Form.textBox_Year_of_Study.Text = DR.ItemArray[13].ToString();
                    List<string> items1 = new List<string>();
                    items1.Add(DR.ItemArray[14].ToString());
                    DataLoad_Form.comboBox_Semester.ItemsSource = items1;
                    DataLoad_Form.comboBox_Semester.Text = DR.ItemArray[14].ToString();
                    DataLoad_Form.comboBox_License.Text = DR.ItemArray[15].ToString();
                    DataLoad_Form.DatePicker_Retirement_Date.Text = DR.ItemArray[16].ToString();
                    DataLoad_Form.DatePicker_Death_Date.Text = DR.ItemArray[17].ToString();
                    DataLoad_Form.checkBox_Idintity_Card.IsChecked = Convert.ToBoolean(DR.ItemArray[18].ToString());
                    DataLoad_Form.checkBox_Oath.IsChecked = Convert.ToBoolean(DR.ItemArray[19].ToString());
                    DataLoad_Form.textBox_Moved_From.Text = DR.ItemArray[20].ToString();
                    List<string> items2 = new List<string>();
                    items2.Add(DR.ItemArray[21].ToString());
                    //DataLoad_Form.comboBox_Section.ItemsSource = items2;
                    //DataLoad_Form.comboBox_Section.Text = DR.ItemArray[21].ToString();
                    List<string> items3 = new List<string>();
                    items3.Add(DR.ItemArray[22].ToString());
                    DataLoad_Form.comboBox_Specialization.ItemsSource = items3;
                    DataLoad_Form.comboBox_Specialization.Text = DR.ItemArray[22].ToString();

                }
               
                for (int i = 1; i <= 3; i++)
                {
                    Engineer_Address EA = new Engineer_Address();
                    EA.Engineer_ID1 = Convert.ToInt32(row[0].ToString());
                    EA.Address_ID1 = i;
                    DataTable dt = EA.Find_Engineer_Address();
                    DataRow DR1;
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        DR1 = dt.Rows[j];
                        if (i == 2)
                        {
                            DataLoad_Form.textBox_Area_Work.Text = DR1.ItemArray[2].ToString();
                            DataLoad_Form.textBox_Street_Work.Text = DR1.ItemArray[3].ToString();
                            DataLoad_Form.textBox_Phone_Work.Text = DR1.ItemArray[4].ToString();
                            DataLoad_Form.textBox_Extra_Info_Work.Text = DR1.ItemArray[5].ToString();
                        }
                        else if (i == 1)
                        {
                            DataLoad_Form.textBox_Area_Temporary_Living.Text = DR1.ItemArray[2].ToString();
                            DataLoad_Form.textBox_Street_Temporary_Living.Text = DR1.ItemArray[3].ToString();
                            DataLoad_Form.textBox_Phone_Temporary_Living.Text = DR1.ItemArray[4].ToString();
                            DataLoad_Form.textBox_Extra_Info_Temporary_Living.Text = DR1.ItemArray[5].ToString();
                        }
                        else if(i==3)
                        {
                            DataLoad_Form.textBox__Area_Permanent_Living.Text = DR1.ItemArray[2].ToString();
                            DataLoad_Form.textBox_Permanent_Living.Text = DR1.ItemArray[3].ToString();
                            DataLoad_Form.textBox_Phone_Permanent_Living.Text = DR1.ItemArray[4].ToString();
                            DataLoad_Form.textBox_Extra_Info_Permanent_Living.Text = DR1.ItemArray[5].ToString();
                        }



                    }
                }
                DataLoad_Form.Button_Add_Engineer.Content = "Update Engineer";
                DataLoad_Form.Show();
            }
            catch (Exception)
            {
            }
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            DataLoad DataLoad_Form = new DataLoad();
            DataLoad_Form.Show();
        }

        private void textBox_Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (RB_ID.IsChecked == true)
                {
                    dataGrid.ItemsSource = Engineers_View.GetData("Select * from Engineer_Personality where Engineer_ID like '" + textBox_Search.Text + "%'").DefaultView;
                }
                if (RB_Name.IsChecked == true)
                {
                    dataGrid.ItemsSource = Engineers_View.GetData("Select * from Engineer_Personality where First_Name like '" + textBox_Search.Text + "%'").DefaultView;
                }
            }
            catch
            {
                dataGrid.ItemsSource = Engineers_View.GetData("Select * from Engineer_Personality").DefaultView;
            }
        }



        private void Button_Deleted_and_Delayed_Engineers_Click(object sender, RoutedEventArgs e)
        {
            Deleted_and_Delayed_Engineers Deleted_and_Delayed_Engineers_Form = new Deleted_and_Delayed_Engineers();
            Deleted_and_Delayed_Engineers_Form.Show();
        }
    }
    
}
