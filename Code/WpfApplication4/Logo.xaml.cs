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

namespace WpfApplication4
{
    /// <summary>
    /// Interaction logic for Logo.xaml
    /// </summary>
    public partial class Logo : Window
    {
        public Logo()
        {
            InitializeComponent();
        }
        public void CloseMethod(object sender, EventArgs e)
        {
            MainWindow MainWindow_Form = new MainWindow();
            MainWindow_Form.Show();
            this.Close();
        }

    }
}
