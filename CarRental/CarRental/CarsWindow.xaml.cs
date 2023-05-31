using CarRental.Models;
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
    /// Logika interakcji dla klasy CarsWindow.xaml
    /// </summary>
    public partial class CarsWindow : Window
    {
        private readonly RentalContext _context;
        public CarsWindow()
        {
            _context = new RentalContext();
            InitializeComponent();
            back.Click += new RoutedEventHandler(Button_Click1);
            add.Click += new RoutedEventHandler(Button_ClickAdd);
            remove.Click += new RoutedEventHandler(Button_ClickRemove);
            update.Click += new RoutedEventHandler(Button_Update);

            foreach (Cars car in _context.Cars.ToList())
            {
                carlist.Items.Add(car.Car_ID + ";" + car.Make + " " + car.Model + " " + car.Year);
            }
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_ClickAdd(object sender, RoutedEventArgs e)
        {
            CarAddWindow carAddWindow = new CarAddWindow();
            carAddWindow.Show();
            this.Close();
        }
        private void Button_ClickRemove(object sender, RoutedEventArgs e)
        {
            foreach(string car in carlist.SelectedItems)
            {
               
                int ID = int.Parse(car.Split(';')[0]);
                var selectedCar = _context.Cars.Where(c => c.Car_ID == ID).SingleOrDefault();
                _context.Cars.Remove(selectedCar);
                _context.SaveChanges();
                
            }

            carlist.Items.Clear();

            foreach (Cars car in _context.Cars.ToList())
            {
                carlist.Items.Add(car.Car_ID + ";" + car.Make + " " + car.Model + " " + car.Year);
            }
        }
        private void Button_Update(object sender, RoutedEventArgs e)
        {
            string? car = carlist.SelectedItems[0].ToString();
            if (car == null)
            {
                CarAddWindow carAddWindow = new CarAddWindow();
                carAddWindow.Show();
                this.Close();
            }
            else
            {
                int ID = int.Parse(car.Split(';')[0]);
                var selectedCar = _context.Cars.Where(c => c.Car_ID == ID).SingleOrDefault();
                CarUpdateWindow carUpdateWindow = new CarUpdateWindow(ID,selectedCar.Make, selectedCar.Model, selectedCar.Year, selectedCar.Color, selectedCar.Rental_Rate, selectedCar.Available);
                carUpdateWindow.Show();
                this.Close();
            }
            
        }
    }
}
