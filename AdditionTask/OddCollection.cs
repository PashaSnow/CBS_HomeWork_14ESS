using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionTask
{
    static class OddCollection
    {
        public static IEnumerable Power(int[] sourceArray)
        {
            if (sourceArray.Length != 0)
            {
                foreach (int item in sourceArray)
                {
                    if (item % 2 == 0)
                    {
                        yield return item;
                    }
                }
            }
            else
                yield break;
        }
    }
}
