using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public delegate bool Compare(string str1, string str2);
        public delegate void Message();
        public static event Message ShowMessage;

        static void Main(string[] args)
        {
            string[] array = { "nsd", "a", "vb", "ab", "asd" };
            ShowMessage += Finish;
            Thread thread = new Thread(() => Sort(array, SortByAscLength));
            thread.Start();

            for (int i = 0; i < 20; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            //thread.Join();
            Console.WriteLine("After asc sort");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        public static void Finish()
        {
            Console.WriteLine("Sort finished");
        }

        public static bool SortByAscLength(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return true;
            }
            else if (str1.Length == str2.Length)
            {
                return (str1.CompareTo(str2) > 0);
            }
            else
            {
                return false;
            }
        }

        public static void Sort(string[] array, Compare compare)
        {
            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (compare(array[i], array[j]))
                        {
                            Swap(array, i, j);
                        }

                    }
                }
            }
            ShowMessage?.Invoke();
        }

        private static void Swap(string[] array, int i, int j)
        {
            string temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
