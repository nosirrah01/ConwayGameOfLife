using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwayTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testInt = ClassLibrary1.Class1.DoSomeLogicTest(1, 2);
            Console.WriteLine(testInt);
            Console.ReadLine();
        }
    }
}
