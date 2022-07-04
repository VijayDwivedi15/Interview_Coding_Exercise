using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercise_for_Interview
{
    class Count_Frequency_of_Numbers_Array
    {
        public static void Main()
        {

            int[] arr = { 1, 3, 4, 1, 3, 5, 2 };

            int[] freq = new int[arr.Length];

            int visited = -1;


            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        freq[j] = visited;
                    }
                }

                if (freq[i] != visited)
                {
                    freq[i] = count;
                }
            }

            for (int i = 0; i < freq.Length; i++)
            {

                if (freq[i] != visited)
                {

                    Console.WriteLine(arr[i] + "=" + freq[i]);
                }
            }

            Console.ReadLine();
        }
    }

}
