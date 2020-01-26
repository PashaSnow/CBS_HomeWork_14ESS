using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<double> list = new MyList<double>();

            for (var i = 0; i < 5; i++)
                list.Add(i * 2);

            var array = list.GetArray();
            Console.WriteLine($"array type is {array.GetType().Name}"); // повертає масив типу

        }
    }
    static class ExtentionClass
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            T[] array = new T[list.Count()];
            int count = 0;
            foreach (var item in list)
            {
                array[count] = item;
                count++;
            }
            return array;
        }
    }
}
