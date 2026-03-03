using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._2
{
    public static class ListHelper
    {
        public static List<int> FilterOddNumbers(List<int> listOfNumbers)
        {
            //1, 2, 3 => 1, 3

            List<int> result = new List<int>();

            for(int i = 0; i < listOfNumbers.Count; i++)
            {
                if (listOfNumbers[i] % 2 != 0)
                {
                    result.Add(listOfNumbers[i]);
                }
            }
            return result;
        }
    }
}
