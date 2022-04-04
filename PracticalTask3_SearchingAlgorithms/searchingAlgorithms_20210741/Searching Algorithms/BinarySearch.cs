using System;
using System.Collections.Generic;
using System.Text;

namespace Searching_Algorithms
{
    class BinarySearch
    {
        public int IterativeFind(string[] array, string value)
        {
            if(array.Length >= 1)
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
            }
            return -1;
        }

        public int RecursiveFind(string[] array, string value, int lowerBound, int length)
        {

            while (lowerBound < length)
            {
                if (length >= 1)
                {
                    int midPoint = (lowerBound + length) / 2;

                    string midValue = array[midPoint];

                    //check if value is contained in element Title
                    bool contains = midValue.ToUpper().Contains(value.ToUpper());

                    //compare values alpahabetically for Order
                    int comparison = String.Compare(midValue, value, comparisonType: StringComparison.OrdinalIgnoreCase);

                    if (contains)
                    {
                        return midPoint;
                    }
                    if (comparison > 0)
                    {
                        return RecursiveFind(array, value, lowerBound, midPoint - 1);
                    }
                    else
                    {
                        return RecursiveFind(array, value, midPoint + 1, length);
                    }

                }
            }
            return -1;
        }

    }                                                                                                                                                                                                   
}


