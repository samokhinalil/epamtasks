using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class StringSorter
    {
        public delegate bool Compare(string str1, string str2);

        public static void Sort(string[] array, Compare compare)
        {
            if(array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if(compare(array[i], array[j]))
                        {
                            Swap(array, i, j);
                        }
                        
                    }
                }
            }
        }

        private static void Swap(string[] array, int i, int j)
        {
            string temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

    }
}
