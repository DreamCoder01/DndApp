using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    class Gear
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public ApiReference Equipment_Category { get; set; } //ApiReference (Equipment Categories)
        public ApiReference Gear_Category { get; set; } //ApiReference (Equipment Categories)
        public Cost Cost { get; set; }
        public int Weight { get; set; }
        public string Url { get; set; }
    }
}
