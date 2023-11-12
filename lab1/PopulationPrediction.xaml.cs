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
    /// Interaction logic for PopulationPrediction.xaml
    /// </summary>
    public partial class PopulationPrediction : Window
    {
        public PopulationPrediction()
        {
            InitializeComponent();
        }

        public void Polution_Growth_Click(object sender, RoutedEventArgs e)
        {
            /*
             * we are going to do programs in this block
             */
            int populationSize = int.Parse(populSize.Text);
            // populSize.text always return with string format
            // we need to convert/parse the input to integer format
            double increaseRate = double.Parse(incrRate.Text) / 100;// will be converted percentage

            int noofdays = int.Parse(comboBoxOne.Text);
            // need the for loop to go from day 1 population to noofdays population
            // day1 start population
            int daysPopulations = populationSize;
            for (int i = 1; i <= noofdays; i++)
            {
                // number of new people
                double increasePopulation = (daysPopulations * increaseRate);

                // calculating day end population
                daysPopulations = (int)(daysPopulations + increasePopulation);

                MessageBox.Show("Day no " + i + " & predicted population: "
                    + daysPopulations);
            }

            MessageBox.Show("Total : " + populationGrowth(populationSize, increaseRate, noofdays));
        }

        public int populationGrowth(int p, double r, int d)
        {
            /*
             * we are going to do programs in this block
             */
            int populationSize = p;
            // populSize.text always return with string format
            // we need to convert/parse the input to integer format
            double increaseRate = r / 100;// will be converted percentage

            int noofdays = d;
            // need the for loop to go from day 1 population to noofdays population
            // day1 start population
            int daysPopulations = populationSize;
            for (int i = 1; i <= noofdays; i++)
            {
                // number of new people
                double increasePopulation = (daysPopulations * increaseRate);

                // calculating day end population
                daysPopulations = (int)(daysPopulations + increasePopulation);

                
            }
            return daysPopulations;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
