using AutomobileLibrary.DataAccess;
using AutomobileLibrary.Repository;
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

namespace AutomobileWPFApp
{
    /// <summary>
    /// Interaction logic for WindowCarManagement.xaml
    /// </summary>
    public partial class WindowCarManagement : Window
    {
        ICarRepository carRepository;
        public WindowCarManagement(ICarRepository repository)
        {
            InitializeComponent();
            carRepository = repository;
        }

        //----------------------------------------------------------
        private Car GetCarObject()
        {
            Car car = null;
            try
            {
                car = new Car()
                {
                    CarId = int.Parse(txtCarId.Text),
                    CarName = txtCarName.Text,
                    Manufacturer = txtManufacturer.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ReleasedYear = int.Parse(txtReleasedYear.Text),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Car");
            }
            return car;
        }

        public void LoadCarList()
        {
            lvCars.ItemsSource = carRepository.GetCars();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LoadCarList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Car List");
            }
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Car car = GetCarObject();
                carRepository.InsertCar(car);
                LoadCarList();
                MessageBox.Show($"{car.CarName} inserted successfully", "Insert Car");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Car");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Car? car = GetCarObject();
                carRepository.UpdateCar(car!);
                LoadCarList();
                MessageBox.Show($"{car!.CarName} updated successfully", "Update Car");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Car");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Car? car = GetCarObject();
                carRepository.DeleteCar(car!);
                LoadCarList();
                MessageBox.Show($"{car!.CarName} deleted successfully", "Delete Car");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Car");
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e) => this.Close();
    }
}