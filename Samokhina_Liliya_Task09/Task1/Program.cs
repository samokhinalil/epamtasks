using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            LinkedList<int> linkedList = new LinkedList<int>();

            for (int i = 1; i <= 6; i++)
            {
                list.Add(i);
                linkedList.AddLast(i);
            }

            EachSecondItemRemover.RemoveEachSecondItem(list);
            EachSecondItemRemover.RemoveEachSecondItem(linkedList);

            //EachSecondItemRemover.RemoveListEachSecondItem(list);
            //EachSecondItemRemover.RemoveLinkedListEachSecondItem(linkedList);

            Console.WriteLine($"list result = {list[0]}");
            Console.WriteLine($"linked list result = {linkedList.First.Value}");
            
            Console.ReadKey();
        }
    }
}
