using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    class Armor
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public EquipmentCategory Equpiment_Category { get; set; }
        public string Armor_Category { get; set; }
        public object Armor_Class { get; set; }
        public int Str_Minimium { get; set; }
        public int Weight { get; set; }
        public Cost Cost { get; set; }
        public string Url { get; set; }
    }
}
