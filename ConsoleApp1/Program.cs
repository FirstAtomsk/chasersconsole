using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {
            ID alex = new ID("alex", 60, "Obninsk", "alex", "12345");
            ID ilya = new ID("ilya", 70, "Moscow", "ilya", "12345");

            Console.WriteLine(alex.weight);
            Console.ReadLine();
        }
    }
}
