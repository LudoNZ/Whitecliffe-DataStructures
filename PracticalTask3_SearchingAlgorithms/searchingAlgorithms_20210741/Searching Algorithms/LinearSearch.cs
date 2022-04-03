using System;
using System.Collections.Generic;
using System.Text;

namespace Searching_Algorithms
{
    class LinearSearch
    {
        public int Find(string[] list, string value)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
