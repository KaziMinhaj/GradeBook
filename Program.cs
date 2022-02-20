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
            book.GraddeAdded += OnGradeAdded;
            book.GraddeAdded += OnGradeAdded;
            book.GraddeAdded -= OnGradeAdded;
            book.GraddeAdded += OnGradeAdded;


            var done = false;
            while(!done){ 
                Console.WriteLine("Enter a grade or enter q to quit.");
                var input = Console.ReadLine();
                if (input == "q") 
                {
                    done = true;
                    continue;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade); 
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
               
            }
            var stats = book.GetStatictics();

            //display
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"Avarage is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }
        static void OnGradeAdded(object sender, EventArgs e) {
            Console.WriteLine("A grade was added");
        }
    }
}
