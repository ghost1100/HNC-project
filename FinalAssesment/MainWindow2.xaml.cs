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

namespace FinalAssesment
{
    /// <summary>
    /// Interaction logic for MainWindow2.xaml
    /// </summary>
    public partial class MainWindow2 : Window
    {
        public MainWindow2()
        {
            InitializeComponent();

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e, Scn);
        }

        private void Button_Click(object sender, RoutedEventArgs e, TextBox scn)
        {
            Class1.FirstName = Frstname.Text;
            Class1.LastName = Lstname.Text;
            string ScottishCanidateNumber = Scn.Text;
            int Lenght = ScottishCanidateNumber.Length;



            if (string.IsNullOrEmpty(Frstname.Text) || string.IsNullOrEmpty(Lstname.Text) || string.IsNullOrEmpty(Scn.Text))
            {
                MessageBox.Show("please fill out each category appropriatly");


            }
            else
            {

                try
                {
                    int scncheck = int.Parse(ScottishCanidateNumber);


                    if (Lenght != 9)
                    {
                        MessageBox.Show("the scottish caniate numbers length should be equal to 9 characters in total");
                    }

                    else
                    {
                        if (lstbx1.SelectedIndex == -1)
                        {
                            MessageBox.Show("please select your appropriate class");
                        }

                        if (lstbx1.SelectedIndex == 1 || lstbx1.SelectedIndex == 2)
                        {
                            MainWindow4 secondWindow = new MainWindow4();
                            secondWindow.Show();
                            this.Close();


                        }


                        if (lstbx1.SelectedIndex == 0)
                        {

                            MainWindow3 secondWindow = new MainWindow3();
                            secondWindow.Show();
                            this.Close();

                        };
                    }

                }
                catch
                {
                    MessageBox.Show("please make sure that your scn is in numbers ");
                }
            }


        }
       
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

