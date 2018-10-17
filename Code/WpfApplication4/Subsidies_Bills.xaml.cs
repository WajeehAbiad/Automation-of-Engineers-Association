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
    /// Interaction logic for Subsidies_Bills.xaml
    /// </summary>
    public partial class Subsidies_Bills : Window
    {
        subsidies_Bill SB = new subsidies_Bill();
        public Subsidies_Bills(int Engineer_ID)
        {
            InitializeComponent();
            Subsidies_Person SP1 = new Subsidies_Person();
            SP1.Engineer_ID1 = Engineer_ID;
            SB.Engineer_ID1 = Engineer_ID;
            SP1.Subsidy_ID1 = 2;
            DataTable dt1=SP1.ViewAll_Recommended_Person();
            List<string> Recommended1 = new List<string>();
            DataRow dr1;
            for (int i = 0; i < dt1.Rows.Count; i++)
			{
                dr1=dt1.Rows[i];
                Recommended1.Add(dr1.ItemArray[0].ToString());
			}
            comboBox_Choose_Name_To_Search_T2.ItemsSource = Recommended1;
            Subsidies_Person SP2 = new Subsidies_Person();
            SP2.Engineer_ID1 = Engineer_ID;
            SP2.Subsidy_ID1 = 1;
            DataTable dt2 = SP2.ViewAll_Recommended_Person();
            List<string> Recommended2 = new List<string>();
            DataRow dr2;
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                dr2 = dt2.Rows[i];
                Recommended2.Add(dr2.ItemArray[0].ToString());
            }
            comboBox_Choose_Name_To_Search_T3.ItemsSource = Recommended2;
            



        }

        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void button_Cancel_T1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Cancel_T2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Cancel_T3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void comboBox_Choose_Name_To_Search_T2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Recommended_Person RP= new Recommended_Person();
            RP.Person_Name1=comboBox_Choose_Name_To_Search_T2.SelectedValue.ToString();
            DataTable dt = RP.Find_Num_Recommended_Person();
            DataRow dr;
            dr = dt.Rows[0];          
            SB.Subsidy_ID1 = 2;            
            SB.Person_ID1 = Convert.ToInt32(dr.ItemArray[0].ToString());
            DataTable DT2 = SB.ViewAll_Subsidies_Bill();
            dataGrid_T2.ItemsSource = DT2.DefaultView;
           
        }

        private void comboBox_Choose_Name_To_Search_T3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Recommended_Person RP1 = new Recommended_Person();
            RP1.Person_Name1 = comboBox_Choose_Name_To_Search_T3.SelectedValue.ToString();
            DataTable dt1 = RP1.Find_Num_Recommended_Person();
            DataRow dr1;
            dr1 = dt1.Rows[0];
            SB.Subsidy_ID1 = 1;
            SB.Person_ID1 = Convert.ToInt32(dr1.ItemArray[0].ToString());
            DataTable DT3 = SB.ViewAll_Subsidies_Bill();
            dataGrid_T3.ItemsSource = DT3.DefaultView;
        }
    }
}
