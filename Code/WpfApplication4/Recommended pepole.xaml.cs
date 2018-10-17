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
    /// Interaction logic for Recommended_pepole.xaml
    /// </summary>
    public partial class Recommended_pepole : Window
    {
        public Recommended_pepole(int Engineer_ID)
        {
            InitializeComponent();
            Subsidies_Person SB = new Subsidies_Person();
            SB.Engineer_ID1 = Engineer_ID;
            DataTable dt = SB.ViewAll_Subsidies_Person();


            dataGrid.ItemsSource=dt.DefaultView;
        }

        public Recommended_pepole()
        {
            // TODO: Complete member initialization
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
