using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Award
    {
        private static int id = 1;
        public int ID { get; private set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Award(string title, string description)
        {
            ID = id;
            Title = title;
            Description = description;
            id++;
        }
    }
}
