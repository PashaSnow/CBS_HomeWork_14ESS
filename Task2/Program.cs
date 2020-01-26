using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> x = new MyList<int>();
            for (int i = 0; i < 5; i++)
            {
                x.Add(i * 2);
            }
            Console.WriteLine("Count " + x.Count);
            Console.WriteLine(new string('-', 15));
            foreach (var item in x)
            {
                Console.WriteLine($"item = {item}, position = {x.Position}");
            }
            Console.WriteLine($"Final positon {x.Position}");
            Console.WriteLine(new string('-', 15));
            Console.WriteLine($"x[3] = {x[3]}");
            Console.WriteLine($"New positon {x.Position}");

        }
    }
}
