using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachingClass
{
    class CoachingTest
    {
        static void Main(string[] args)
        {
            Coaching coaching = new Coaching("Football", 20, "16:00", 100.00m);
            Console.WriteLine(coaching.DisplayDetails());
            Console.ReadLine();
        }
    }
}
