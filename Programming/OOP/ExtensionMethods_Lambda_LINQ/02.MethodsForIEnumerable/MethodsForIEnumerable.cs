using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MethodsForIEnumerable
{
    public static class MethodsForIEnumerable
    {
        public static T SumAll<T>(this IEnumerable<T> data)
        {
            dynamic sum = 0;
            foreach (var item in data)
            {
                sum += (dynamic)item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> data) where T : IComparable<T>
        {
            dynamic product = 1;
            foreach (var item in data)
            {
                product *= (dynamic)item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> data) where T : IComparable<T>
        {
            T min = data.First<T>();

            foreach (var item in data)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> data) where T : IComparable<T>
        {
            T max = data.First<T>();

            foreach (var item in data)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> data) where T : IComparable<T>
        {
            return (dynamic)data.SumAll<T>() / data.Count<T>();
        }

    }
}
