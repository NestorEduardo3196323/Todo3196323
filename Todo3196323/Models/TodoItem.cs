using System;
using System.Collections.Generic;
using System.Text;

namespace Todo3196323.Models
{
    public class TodoItem
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Notes { get; set; }
        public bool Done { get; set; }
    }
}

