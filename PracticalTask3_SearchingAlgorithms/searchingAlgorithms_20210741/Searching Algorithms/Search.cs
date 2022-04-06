using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Searching_Algorithms
{
    class Search
    {
        public int LinearSearch(string[] list, string value)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] != null)
                {
                    if (list[i].ToUpper().Contains(value.ToUpper()))
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        public List<string> FindAll(string[] array, string value)
        {
            List<string> list = new List<string>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null)
                {
                    if (array[i].ToUpper().Contains(value.ToUpper()))
                    {
                        list.Add(array[i]);
                    }
                }
            }

            //List<string> noDupes = list.Distinct().ToList();
            list = list.Distinct().ToList();

            return list;
        }

        public int BinaryIterativeSearch(string[] array, string value)
        {
            if (array.Length >= 1)
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
                        upperBound = midPoint;
                    }
                    else
                    {
                        lowerBound = midPoint + 1;
                    }

                }
            }
            return -1;
        }

        public int BinaryRecursiveSearch(string[] array, string value, int lowerBound, int length)
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
                        return BinaryRecursiveSearch(array, value, lowerBound, midPoint);
                    }
                    else
                    {
                        return BinaryRecursiveSearch(array, value, midPoint + 1, length);
                    }

                }
            }
            return -1;
        }
    }
}
