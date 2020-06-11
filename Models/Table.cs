using System;
using System.Collections.Generic;

namespace EFTest.Models
{
    public partial class Table
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
