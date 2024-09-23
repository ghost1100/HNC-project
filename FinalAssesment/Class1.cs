using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssesment
{

    class Class1
    {
        public static List<int> grades = new List<int>();//this is where we store the grades 
        public static string[] results = { "No guaranteed progression to offer, student continues with remaining HNC units", "Progression onto HND Networking or HND Software Development will be offered (conditional on the successful completion of all remaining HNC units)", "Progression onto the 2nd year of an appropriate degree Programme (conditional on the successful completion of all remaining HNC units)", "Progression onto the 2nd year of an appropriate degree  Programme with possible company sponsorship (conditional on the successful completion of all remaining HNC units)" };
        //pick selected index.length for specific grade average
        public static string[] topics = { "Computer Systems Fundamentals (H175 34)", "Developing Software: Introduction (H173 34)", "Professionalism and Ethics in Computing (H1F7 34)", "Troubleshooting Computing Problems (H177 34)", "Project Management: An Introduction (H17D 34)" ,"click next to move on"};
        public static string FirstName;//the string from the users first name
        public static string LastName;/// the string from the users last name
        // int total = grades.Sum();
        // public static int average1= sum / grades.Count();
    }
}
