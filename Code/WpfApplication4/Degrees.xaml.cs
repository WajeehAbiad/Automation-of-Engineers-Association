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
    /// Interaction logic for Degrees.xaml
    /// </summary>
    public partial class Degrees : Window
    {
        public Degrees(int Engineer_ID)
        {
            InitializeComponent();
            Engineer_Degree ED = new Engineer_Degree();
            ED.Engineer_ID1 = Engineer_ID;
            DataTable dt = ED.ViewAll_Engineer_Degree();


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

        private void button_Save_Click(object sender, RoutedEventArgs e)
        {
            Promotion_Attention Promotion_Attention_Form = new Promotion_Attention();
            Promotion_Attention_Form.Show();
        }
    }
}
