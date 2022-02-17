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
            
            book.ShowStatictics();
        }
    }
}
