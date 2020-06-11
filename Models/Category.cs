using System;
using System.Collections.Generic;

namespace EFTest.Models
{
    public partial class Category
    {
        public Category()
        {
            Table = new HashSet<Table>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Table> Table { get; set; }
    }
}
