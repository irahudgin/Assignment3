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
using System.Windows.Shapes;

namespace lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class BankCharges : Window
    {   
        public List<int> chequeOptions = new List<int>();

        public double startingFee = 10.00;
        public double startingBalance = 1200.00;
        public BankCharges()
        {
            InitializeComponent();

            chequeOptions.Add(10);
            chequeOptions.Add(30);
            chequeOptions.Add(50);
            chequeOptions.Add(100);

            comboBox.ItemsSource = chequeOptions;
            setMonthlyFee(Convert.ToDouble(comboBox.SelectedItem));
            
            accountBalance.Text = startingBalance.ToString("F2");

           /// Console.WriteLine("The bank account stuff is: "+bankacc.AccTotal);
        }

        public void setMonthlyFee(double item)
        {
            monthlyFee.Text = startingFee.ToString("F2");
            double selectedValue = item;
            switch (item)
            {
                case 10:
                    monthlyFee.Text = (this.startingFee + selectedValue * 0.10).ToString("F2");
                    break;

                case 30:
                    monthlyFee.Text = (this.startingFee + selectedValue * 0.08).ToString("F2");
                    break;

                case 50:
                    monthlyFee.Text = (this.startingFee + selectedValue * 0.06).ToString("F2");
                    break;

                case 100:
                    monthlyFee.Text = (this.startingFee + selectedValue * 0.10).ToString("F2");
                    break;

                default:
                    monthlyFee.Text = "10.00";
                    break;
            }
        }

        public void createCheques_Click(object sender, RoutedEventArgs e)
        {
            startingFee = 10.00;
            setMonthlyFee(Convert.ToDouble(comboBox.SelectedItem));
            if (double.TryParse(accountBalance.Text, out double amount))
            {
                if (amount < 400.00 && amount > 0)
                {
                    this.startingFee += 15.00;
                    setMonthlyFee(Convert.ToDouble(comboBox.SelectedItem));
                }
                else if (amount >= 400)
                {
                    this.startingFee = 10.00;
                    setMonthlyFee(Convert.ToDouble(comboBox.SelectedItem));
                }
                else
                {
                    MessageBox.Show("Please enter a valid number");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
