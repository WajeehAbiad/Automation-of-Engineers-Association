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
    /// Interaction logic for fees.xaml
    /// </summary>
    public partial class fees : Window
    {
        public fees(int Engineer_ID)
        {
            InitializeComponent();
            Fee_Detail FD1 = new Fee_Detail();
            Fee_Detail FD2 = new Fee_Detail();
            Fee_Detail FD3 = new Fee_Detail();
            FD1.Fee_ID1 = 1;
            FD1.Year1 = DateTime.Now.Year;
            FD2.Year1 = DateTime.Now.Year;
            FD3.Year1 = DateTime.Now.Year;
            FD2.Fee_ID1 = 2;
            FD3.Fee_ID1 = 3;
            DataTable dt1 = FD1.ViewAll_Fee_Detail();
            dataGrid2_T1.ItemsSource = dt1.DefaultView;
            DataTable dt2 = FD2.ViewAll_Fee_Detail();
            dataGrid2_T2.ItemsSource=dt2.DefaultView;
            DataTable dt3 = FD3.ViewAll_Fee_Detail();
            dataGrid2_T3.ItemsSource = dt3.DefaultView;
            Engineer_Fee EF1 = new Engineer_Fee();
            Engineer_Fee EF2 = new Engineer_Fee();
            Engineer_Fee EF3 = new Engineer_Fee();
            EF1.Fee_ID1 = 1;
            EF1.Year1 = DateTime.Now.Year;
            EF2.Year1 = DateTime.Now.Year;
            EF3.Year1 = DateTime.Now.Year;
            EF2.Fee_ID1 = 2;
            EF3.Fee_ID1 = 3;
            EF1.Engineer_ID1 = Engineer_ID;
            EF2.Engineer_ID1 = Engineer_ID;
            EF3.Engineer_ID1 = Engineer_ID;
            DataTable DT1 = EF1.ViewAll_Engineer_Fee();
            dataGrid1_T1.ItemsSource = DT1.DefaultView;
            DataTable DT2 = EF2.ViewAll_Engineer_Fee();
            dataGrid1_T2.ItemsSource = DT2.DefaultView;
            DataTable DT3 = EF3.ViewAll_Engineer_Fee();
            dataGrid1_T3.ItemsSource = DT3.DefaultView;
            
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
    }
}
