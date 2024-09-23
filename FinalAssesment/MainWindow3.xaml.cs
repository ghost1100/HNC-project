using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using static System.Net.Mime.MediaTypeNames;

namespace FinalAssesment
{
    /// <summary>
    /// Interaction logic for MainWindow3.xaml
    /// </summary>
    public partial class MainWindow3 : Window
    {
         int pos = 0;
        public MainWindow3()
        {
            InitializeComponent();
            Users.Text = (Class1.FirstName) +("   ")+ (Class1.LastName) + ("- Level HNC computing");
            Units.Content = Class1.topics[0];
            
            //pos = Class1.topics.Length;
        }
        
        //MainWindow3.users.text= Class1.Firstname+ class1.lastName+"hnc computing"

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var temp = Grade.Text;


            try
            {
                if (pos == 4)
                {
                    nxtbtn.Content = "submit";
                }
                if (pos == 5)
                {
                    Grade.IsEnabled = false;
                    nxtbtn.Content = "submit";
                    int sum = Class1.grades.Sum();
                    float average = sum / Class1.grades.Count();
                    MessageBox.Show("your average grade is " + average);
                    MainWindow5 secondWindow = new MainWindow5();
                    secondWindow.Show();
                    this.Close();

                }
                else if (int.TryParse(temp, out int grade) && (grade <= 100 && grade >= 0))//converts the text into an int to allow the sum function to easily add up the grades
                {
                    pos++;
                  //  MessageBox.Show(" position " + pos);
                    Units.Content = Class1.topics[pos];
                    Class1.grades.Add(grade);
                    Grade.Clear();
                    Grade.Focus();

                }//this is where it adds the grades to the array or list via the add method

                else
                {
                    MessageBox.Show("incorrect input try again");
                    Grade.Clear();
                    Grade.Focus();
                }


            }
            catch(Exception ex)
            {
               // MessageBox.Show(ex.ToString());
            }
           
            //next btn
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Grade.Text, out int grade))//converts the text into an int to allow the sum function to easily add up the grades
            { Class1.grades.Add(grade); }//this is where it adds the grades to the array or list via the add method


            if (pos < Class1.topics.Length &&(pos!=0))
            {
                pos--;
                Units.Content = Class1.topics[pos];
                Grade.Clear();
                Class1.grades.Remove(grade);
                MessageBox.Show("your grade has been removed");
             
               

            }
            


        }
    }
    }

/*
                        
*/