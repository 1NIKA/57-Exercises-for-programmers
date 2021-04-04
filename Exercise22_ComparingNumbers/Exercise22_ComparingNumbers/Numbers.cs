using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise22_ComparingNumbers
{
    public static class Numbers
    {
        public static int LargestNumber(this IEnumerable<int> source)
        {
            return LargestNumberImpl(source);
        }

        private static int LargestNumberImpl(IEnumerable<int> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            using (IEnumerator<int> iterator = source.GetEnumerator())
            {
                int current = iterator.Current;
                foreach (int item in source)
                {
                    if (iterator.MoveNext())
                    {
                        if (iterator.Current > current)
                            current = iterator.Current;
                    }
                }
                
                return current;
            }
        }
    }
}
