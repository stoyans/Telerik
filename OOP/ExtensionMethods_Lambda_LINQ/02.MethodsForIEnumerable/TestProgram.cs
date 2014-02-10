/*Implement a set of extension methods for IEnumerable<T> 
 * that implement the following group functions: sum, product, min, max, average.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MethodsForIEnumerable
{
    class TestProgram
    {
        static void Main()
        {
            int[] nums = new int[] { 1, 2, 3, -1, 6};
            
            Console.WriteLine(nums.SumAll());
            Console.WriteLine(nums.Product());
            Console.WriteLine(nums.Min());
            Console.WriteLine(nums.Max());
            Console.WriteLine(nums.Average());
        }
    }
}
