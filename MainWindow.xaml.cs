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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DesSezLibrary;
using static Bibiteka2.MainWindow;

namespace Bibiteka2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public class Car
        {
            public string MachineBrand { get; set; }
            public string Model { get; set; }
        }

        public MainWindow()
        {
            InitializeComponent();


        }
        public void Click(object sender, RoutedEventArgs e)
        {
            Car car = new Car();
            car.MachineBrand = M1.Text;
            car.Model = Mo1.Text;

            Car car2 = new Car();
            car2.MachineBrand = M2.Text;
            car2.Model = Mo2.Text;

            Car car3 = new Car();
            car3.MachineBrand = M3.Text;
            car3.Model = Mo3.Text;

            List<Car> carM1 = new List<Car>();

            carM1.Add(car);
            carM1.Add(car2);
            carM1.Add(car3);

            Deserialization_Serialization.S(carM1);

        }
    }
}
