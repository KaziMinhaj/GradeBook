using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class Book
    {
        public Book(string name) 
        {
            grades = new List<double>();
            this.name = name;
        }
        private  List<double> grades;
        private string name;
        public void AddGrade(double grade) {
            grades.Add(grade);
        }
        public void ShowStatictics() {
            var result = 0.0;
            var highgrade = double.MinValue;
            var lowgrade = double.MaxValue;
            foreach (var number in grades) { 
                lowgrade = Math.Min(number,lowgrade);
                highgrade = Math.Max(number,highgrade);
                result = result + number;
            }

            result = result / grades.Count;
        
            Console.WriteLine($"The lowest grade is {lowgrade}");
            Console.WriteLine($"The highest grade is {highgrade}");
            Console.WriteLine($"Avarage is {result:N1}");
        }

    }
}
