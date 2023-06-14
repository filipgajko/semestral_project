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

namespace CarRental
{
    /// <summary>
    /// Logika interakcji dla klasy RentalsWindow.xaml
    /// </summary>
    public partial class RentalsWindow : Window
    {
        public RentalsWindow()
        {
            InitializeComponent();
            back.Click += new RoutedEventHandler(Button_Click1);
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
