using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Logika interakcji dla klasy CarUpdateWindow.xaml
    /// </summary>
    public partial class CarUpdateWindow : Window
    {
        private readonly RentalContext _context;
        private readonly int ID;
        private readonly string makeCar;
        private readonly string modelCar;
        private readonly int yearCar;
        private readonly string colorCar;
        private readonly decimal rental_rateCar;
        private readonly bool availableCar;

        public CarUpdateWindow(int ID, string makeCar, string modelCar, int yearCar, string colorCar, decimal rental_rateCar, bool availableCar)
        {
            InitializeComponent();
            this.ID = ID;
            this.makeCar = makeCar;
            make.Text = makeCar;
            this.modelCar = modelCar;
            model.Text = modelCar;
            this.yearCar = yearCar;
            year.Text = yearCar.ToString();
            this.colorCar = colorCar;
            color.Text = colorCar;
            this.rental_rateCar = rental_rateCar;
            rental_rate.Text = rental_rateCar.ToString();
            this.availableCar = availableCar;
            available.IsChecked = availableCar;

            _context = new RentalContext();



        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var car = _context.Cars.Where(c => c.Car_ID == ID).SingleOrDefault();
            car.Model = model.Text.Trim();
            car.Rental_Rate = decimal.Parse(rental_rate.Text.Trim());
            car.Make = make.Text.Trim();
            car.Year = int.Parse(year.Text.Trim());
            car.Available = (bool)available.IsChecked;
            car.Color = color.Text.Trim();

            _context.SaveChanges();

            CarsWindow carsWindow = new CarsWindow();
            carsWindow.Show();
            this.Close();
            
        }
    }
}
