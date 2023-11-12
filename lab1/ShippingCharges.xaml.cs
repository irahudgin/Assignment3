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

namespace lab1
{
    /// <summary>
    /// Interaction logic for ShippingCharges.xaml
    /// </summary>
    public partial class ShippingCharges : Window
    {
        public ShippingCharges()
        {
            InitializeComponent();
        }

        private double getWeight()
        {
            if (double.TryParse(Weight.Text, out double weight))
            {
                if (weight < 0)
                {
                    MessageBox.Show("Enter a number above 0");
                    return 0;
                }
                else
                {
                    return weight;
                }
            }
            else
            {
                MessageBox.Show("Enter Valid number");
                return 0;
            }
            
        }

        private double getDistance()
        {
            if (double.TryParse(Distance.Text, out double distance))
            {
                if (distance < 0)
                {
                    MessageBox.Show("Enter a number above 0");
                    return 0;
                }
                else
                {
                    return distance;
                }
            }
            else
            {
                MessageBox.Show("Enter Valid number");
                return 0;
            }
        }

        private double calculateShippingCost()
        {
            double weight = getWeight();
            double distance = getDistance();
            double rate;

            if (weight <= 2)
            {
                rate = 1.10;
            }
            else if (weight > 2 && weight < 6)
            {
                rate = 2.20;
            }
            else if (weight > 6 && weight < 10)
            {
                rate = 3.70;
            }
            else
            {
                rate = 4.80;
            }

            if (distance < 1000)
            {
                return rate;
            }
            else
            {
                int proratedDistance = (int)distance / 500;
                return proratedDistance * rate;
            }
        }

        private void shippingButton_Click(object sender, RoutedEventArgs e)
        {
            shippingFee.Text = calculateShippingCost().ToString("F2");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
