using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPositionTestInTdd
{
    class Program
    {
        static void Main(string[] args)
        {
           // string teststring = "this hi is string";
            var teststring = Console.ReadLine();
            var checkString = new CheckStringPosition().CheckPosition(teststring);
            Console.WriteLine(checkString);
            Console.ReadKey();
        }
    }
}
