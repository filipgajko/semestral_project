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
    /// Logika interakcji dla klasy CarAddWindow.xaml
    /// </summary>
    public partial class CarAddWindow : Window
    {
        private readonly RentalContext _context;
        public CarAddWindow()
        {
            _context = new RentalContext();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string makeCar = make.Text.Trim();
            string modelCar = model.Text.Trim();
            int YearCar = int.Parse(year.Text.Trim());
            string colorCar = color.Text.Trim();
            decimal rentalrateCar = decimal.Parse(rental_rate.Text.Trim());
            bool availableCar = (bool)available.IsChecked;
            _context.Cars.Add(new Models.Cars()
            {
                Make = makeCar,
                Model = modelCar,
                Year = YearCar,
                Color = colorCar,
                Rental_Rate = rentalrateCar,
                Available = availableCar
            });
            _context.SaveChanges();

            CarsWindow carsWindow = new CarsWindow();
            carsWindow.Show();
            this.Close();
        }

        private void model_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
