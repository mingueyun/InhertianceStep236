using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertianceStep236
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee badge = new Employee();

            badge.FirstName = "Sample";
            badge.LastName = "student";


            badge.SayName();
            Console.ReadLine();
        }
    }
    
}
