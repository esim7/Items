using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Item : Entity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public string Weight { get; set; }
    }
}
