using System;
using System.Collections.Generic;
using System.Text;

namespace Searching_Algorithms
{
    class BinarySearch
    {
        public int IterativeFind(string[] array, string value)
        {
            int lowerBound = 0;
            int upperBound = array.Length;

            while (lowerBound < upperBound)
            {
                int midPoint = (lowerBound + upperBound) / 2;

                string midValue = array[midPoint];

                //check if values are equal
                bool areEqual = String.Equals(midValue, value, StringComparison.OrdinalIgnoreCase);

                bool contains = midValue.ToUpper().Contains(value.ToUpper());

                //compare value alpahabetically
                int comparison = String.Compare(midValue, value, comparisonType: StringComparison.OrdinalIgnoreCase);

              //if (comparison < 0)
              //  {
              //      Console.WriteLine($"<{midValue}> is less than <{value}>");
              //  }

              //  else if (comparison > 0)
              //  {
              //      Console.WriteLine($"<{midValue}> is greater than <{value}>");
              //  }

              //  else
              //  {
              //      Console.WriteLine($"<{midValue}> and <{value}> are equivalent in order");
              //  }

                if (contains)
                {
                    return midPoint;
                }
                if (comparison > 0)
                    {
                        upperBound = midPoint - 1;
                    }
                    else
                    {
                        lowerBound = midPoint + 1;
                    }

                }
            return -1;
        }

    }


}


