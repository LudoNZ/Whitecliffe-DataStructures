using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Searching_Algorithms
{
    class LinearSearch
    {
        public int Find(string[] list, string value)
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
    }
}
