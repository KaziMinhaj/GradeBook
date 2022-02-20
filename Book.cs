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
        public Statistics GetStatictics() {

            var result = new Statistics();
            result.Average = 0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average = result.Average + grade;
            } 

            result.Average = result.Average / grades.Count;

            return result;
        }

    }
}
