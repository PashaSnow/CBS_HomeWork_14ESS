using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<string, string> x = new MyDictonary<string, string>(3);
            x.Add(0, "pen", "ручка");
            x.Add(1, "work", "робота");
            x.Add(2, "house", "дом");
            x.Add("car", "автомобиль");
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 16));
            Console.WriteLine("Current = " + x.Current);
            Console.WriteLine(x[1]);
            Console.WriteLine("Current = " + x.Current);
            Console.WriteLine("Count " + x.Count);
        }
    }
}
