using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercise_for_Interview
{
    class Find_Missing_Number_from_Array
    {
        public static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 6, 7, 8, 9, 10 };

            int missingNumber, Totalsum;

            Totalsum = (arr.Length + 1) * (arr.Length + 2) / 2;


            foreach (int item in arr)
            {
                Totalsum = Totalsum - item;
            }
            missingNumber = Totalsum;

            Console.WriteLine("missing number  : {0}", missingNumber);
            Console.ReadLine();
        }

        
    }
}
