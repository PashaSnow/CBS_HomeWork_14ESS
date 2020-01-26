using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            IEnumerable newArray = OddCollection.Power(array);

            foreach (var item in newArray)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
