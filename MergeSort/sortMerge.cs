using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public class sortMerge
    {
        public int[] Merge(int[] a, int[] b)
        {
            int[] result = new int[a.Length + b.Length];

            int i = 0;
            int j = 0;
            int count = 0;
            while (i < a.Length || j < b.Length)
            {
                if(i < a.Length && j< b.Length)
                {
                    if (a[i] <= b[j])
                    {
                        result[count] = a[i];
                        count++;
                        i++;
                    }
                    else
                    {
                        result[count] = b[j];
                        count++;
                        j++;
                    }
                }
                else if(i < a.Length)
                {
                    result[count] = a[i];
                    count++;
                    i++;
                }
                else if(j < b.Length)
                {
                    result[count] = b[j];
                    count++;
                    j++;
                }
            }

            return result;
        }

        public int[] Sort(int[] input)
        {
            if (input.Length <= 1) return input;
            int[] L;
            int[] R;
            var sizer = input.Length % 2 == 0 ? input.Length / 2 : input.Length / 2 + 1;
            L = new int[input.Length/2];
            R = new int[sizer];

            int count = 0;

            for (int i = 0; i < input.Length/2; i++)
            {
                L[i] = input[count];
                count++;
            }

            for (int i = 0; i < sizer; i++)
            {
                R[i] = input[count];
                count++;
            }

            L = Sort(L);
            R = Sort(R);

            return Merge(L, R);
        }
    }
}
