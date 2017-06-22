using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("Hi");
            Console.WriteLine(msg.Display());
            Console.ReadKey();
        }
    }
}
