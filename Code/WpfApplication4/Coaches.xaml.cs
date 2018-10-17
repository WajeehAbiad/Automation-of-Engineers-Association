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
    /// Interaction logic for Coaches.xaml
    /// </summary>
    public partial class Coaches : Window
    {
        public Coaches(int Engineer_ID)
        {
            InitializeComponent();
            Trainer_Coach TC = new Trainer_Coach();
            TC.ID_Coach1 = Engineer_ID;
            DataTable dt = TC.ViewAll_Trainer();
            dataGrid2.ItemsSource = dt.DefaultView;
            Trainer_Coach TC1 = new Trainer_Coach();
            TC1.ID_Trainer1 = Engineer_ID;
            DataTable dt1 = TC1.ViewAll_Coach();
            dataGrid1.ItemsSource = dt1.DefaultView;
            
        }

        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
