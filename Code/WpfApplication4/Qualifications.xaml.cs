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
using ClassEngineers;
using System.Data;
using System.Data.SqlClient;

namespace WpfApplication4
{
    /// <summary>
    /// Interaction logic for Qualifications.xaml
    /// </summary>
    public partial class Qualifications : Window
    {

        public Qualifications(int Engineer_ID)
        {
            InitializeComponent();
            Engineer_Qualification EQ = new Engineer_Qualification();
            EQ.Engineer_ID1 = Engineer_ID;
            DataTable dt = EQ.ViewAll_Engineer_Qualification();
            dataGrid.ItemsSource = dt.DefaultView;
            
        }
        
        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void button_Cancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
