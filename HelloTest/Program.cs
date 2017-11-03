using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloTest
{
    class Program
    {
        static void Main(string[] args)
        {
#if AW
            Console.WriteLine("Hello World AW !");
#endif
#if AS
            Console.WriteLine("Hello World AS !");
#endif
            Console.ReadLine();
        }
    }
}
