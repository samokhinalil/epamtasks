using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAndAwards.Entities
{
    public class Award
    {
        private static int id = 1;
        public int ID { get; set; }

        [StringLength(50), Required]
        public string Title { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public Award()
        {
        }

        public Award(string title, string description)
        {
            ID = id;
            Title = title;
            Description = description;
            id++;
        }

        public Award(int id, string title, string description)
        {
            ID = id;
            Title = title;
            Description = description;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
