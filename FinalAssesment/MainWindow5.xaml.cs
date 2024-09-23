using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
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


namespace FinalAssesment
{
    /// <summary>
    /// Interaction logic for MainWindow5.xaml
    /// </summary>
    public partial class MainWindow5 : Window
    {
        public MainWindow5()
        {
            InitializeComponent();
        
        }

        private void restrt_Click(object sender, RoutedEventArgs e)
        {//starts over 
            Class1.grades.Clear();
            MainWindow secondWindow = new MainWindow();
            secondWindow.Show();
            this.Close();
        }

        private void shogrd_Click(object sender, RoutedEventArgs e)
        {//can create a for loop for grade from .... to ++ 
            int sum = Class1.grades.Sum();
            int average = sum / Class1.grades.Count();
            if(average <= 49)
            {
                finals.Content = Class1.results[0];
            }
            if (average >= 49|| average <= 69)
            {
                finals.Content = Class1.results[1];
            }
            if (average >= 70|| average <= 79)
            {
                finals.Content = Class1.results[2];
            }
            if (average >= 80)
            {
                finals.Content = Class1.results[3];
            }
        }

        private void ucas_Click(object sender, RoutedEventArgs e)
        {

            System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "http://www.ucas.com", UseShellExecute = true });
        }
    }
}
