using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSubSetNonAdjacentElements
{
    public class Program
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            //;
            //int res = MaxSubsetSum(arr);

            //textWriter.WriteLine(res);

            //textWriter.Flush();
            //textWriter.Close();

            int[] array = new int[] { 2, 1, 5, 8, 4 };

            Console.WriteLine(MaxSubsetSum(array));

            Console.ReadKey();
        }

        static int MaxSubsetSum(int[] arr)
        {

            int include = arr[0];
            int exclude = 0;
            int excludeBuffer;
            int i;

            var result = 0;

            for (i = 1; i < arr.Length; i++)
            {
                if (include > exclude)
                    excludeBuffer = include;
                else
                    excludeBuffer = exclude;

                include = exclude + arr[i];
                exclude = excludeBuffer;
            }

            if (include > exclude)
                result = include;
            else
                result = exclude;

            return result;
        }
    }
}
