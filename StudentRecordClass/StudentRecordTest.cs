using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecordClass
{
    class StudentRecordTest
    {
        static void Main(string[] args)
        {
            Student student = new Student("TM13", "Tim Mallory", 30, 22, 47);

            Console.WriteLine($"Aggregated result is: {student.GetAggregate()}");
            Console.WriteLine($"Percentage result is: {student.GetPercentage()}");

            Console.ReadLine();
        }
    }
}
