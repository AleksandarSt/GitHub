using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSequence
{
    class LongestIncreasingSequence
    {
        static void Main()
        {
            Console.WriteLine("Enter some array elements ...");
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            StringBuilder currentString=new StringBuilder();

            List<string> list=new List<string>();

            int counter = 0;




            while (true)
            {

                do
                {
                    currentString.Append(array[counter] + " ");
                    counter++;

                } while (array[counter] < array[counter + 1]);


                list.Add(currentString.ToString());
                currentString.Clear();
                if (counter==array.Length)
                {
                    break;
                }
            }


            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

        }
    }
}
