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


namespace WpfApplication4
{
    /// <summary>
    /// Interaction logic for Trainers.xaml
    /// </summary>
    public partial class Coaches : Window
    {
        public Coaches()
        {
        }
        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void textBox_Coaches_Engineer_ID_Text_Changed(object sender, TextChangedEventArgs e)
        {
            //try
            //{
            //    SqlConnection Connection = new SqlConnection("Data Source=asus;Initial Catalog=Engineers;Integrated Security=True");
            //    SqlDataAdapter DataAdapter = new SqlDataAdapter("Select * from Trainer_Coach where ID_Trainer =" + Convert.ToInt32(textBox_Trainer_Engineer_ID.Text), Connection);
            //    DataSet _DataSet = new DataSet();
            //    DataAdapter.Fill(_DataSet);


            //    dataGrid.ItemsSource = _DataSet.Tables[0].DefaultView;
            //}
            //catch (Exception)
            //{

                
            //}


        }

        private void button_Cancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
