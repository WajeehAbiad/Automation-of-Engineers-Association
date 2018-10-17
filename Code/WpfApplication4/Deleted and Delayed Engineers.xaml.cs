using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication4
{
	/// <summary>
	/// Interaction logic for Deleted_and_Delayed_Engineers.xaml
	/// </summary>
	public partial class Deleted_and_Delayed_Engineers : Window
	{
		public Deleted_and_Delayed_Engineers()
		{
			this.InitializeComponent();
            DataGridTextColumn First = new DataGridTextColumn();
            First.Header = "First_Name";
            dataGrid1_T1.Columns.Add(First);
            DataGridTextColumn Last = new DataGridTextColumn();
            Last.Header = "Last_Name";
            dataGrid1_T1.Columns.Add(Last);
            DataGridTextColumn Total = new DataGridTextColumn();
            Total.Header = "Total_Amount";
            dataGrid1_T1.Columns.Add(Total);
            DataGridTextColumn Paied = new DataGridTextColumn();
            Paied.Header = "Paied";
            dataGrid1_T1.Columns.Add(Paied);
            DataGridTextColumn Remains = new DataGridTextColumn();
            Remains.Header = "Remaines_Amount";
            dataGrid1_T1.Columns.Add(Remains);
            DataGridTextColumn First1 = new DataGridTextColumn();
            First1.Header = "First_Name";
            dataGrid1_T2.Columns.Add(First1);
            DataGridTextColumn Last1 = new DataGridTextColumn();
            Last1.Header = "Last_Name";
            dataGrid1_T2.Columns.Add(Last1);
            DataGridTextColumn Year = new DataGridTextColumn();
            Year.Header = "Year";
            dataGrid1_T2.Columns.Add(Year);
            DataGridTextColumn Total1 = new DataGridTextColumn();
            Total1.Header = "Total_Amount";
            dataGrid1_T2.Columns.Add(Total1);
            DataGridTextColumn Paied1 = new DataGridTextColumn();
            Paied1.Header = "Paied";
            dataGrid1_T2.Columns.Add(Paied1);
            DataGridTextColumn Remains1 = new DataGridTextColumn();
            Remains1.Header = "Remaines_Amount";
            dataGrid1_T2.Columns.Add(Remains1);
			
			// Insert code required on object creation below this point.
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