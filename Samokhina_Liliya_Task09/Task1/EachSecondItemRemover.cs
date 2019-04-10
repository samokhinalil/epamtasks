using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class EachSecondItemRemover
    {
        public static void RemoveListEachSecondItem<T>(List<T> list)
        {
            int i = 1;
            while (list.Count > 1)
            {
                list.RemoveAt(i);
                i++;
                if (i > list.Count)
                {
                    i = 1;
                }
                if (i == list.Count)
                {
                    i = 0;
                }
            }
        }

        public static void RemoveLinkedListEachSecondItem<T>(LinkedList<T> linkedList)
        {
            var item = linkedList.First;
            while(linkedList.Count > 1)
            {
                if (item.Next != null)
                {
                    linkedList.Remove(item.Next);
                }
                else
                {
                    linkedList.Remove(linkedList.First);
                    item = linkedList.First;
                    continue;
                }

                if (item.Next != null)
                {
                    item = item.Next;
                }
                else
                {
                    item = linkedList.First;
                }
            }
        }

        public static void RemoveEachSecondItem<T>(ICollection<T> collection)
        {
            int i = 1;
            while (collection.Count > 1)
            {
                collection.Remove(collection.ElementAt(i));
                i++;
                if (i > collection.Count)
                {
                    i = 1;
                }
                if (i == collection.Count)
                {
                    i = 0;
                }
            }
        }
    }
}
