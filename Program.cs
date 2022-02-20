using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class Program
    {
        static void Main(String[] args) {
            var book = new Book("Scott grade book");
            book.AddGrade(90);
            book.AddGrade(85);            
            var stats = book.GetStatictics();

            //display
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"Avarage is {stats.Average:N1}");
        }
    }
}
