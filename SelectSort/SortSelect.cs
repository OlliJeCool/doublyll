using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectSort
{
    public class SortSelect
    {
        public int[] input { get; set; }
        public void Run()
        {
            int count = 0;
            for (int j = count; j < input.Length; j++)
            {
                int index = 0;
                int temp = input[count];
                for (int i = count; i < input.Length; i++)
                {
                    if(input[i] < temp)
                    {
                        temp = input[i];
                        index = i;
                    }
                }
                if (index != 0)
                {
                    int tempnum = input[count];
                    input[count] = input[index];
                    input[index] = tempnum;
                }
                count++;
            }
        }
    }
}
