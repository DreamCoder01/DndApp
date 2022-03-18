using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    class Weapon
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public ApiReference Equipment_Category { get; set; } //ApiReference (Equipment_Category)
        public string Weapon_Category { get; set; }
        public string Weapon_Range { get; set; }
        public string Category_Range { get; set; }
        public Cost Cost { get; set; }
        public object Damage { get; set; }
        public object Two_Handed_Damage { get; set; }
        public object Range { get; set; }
        public int Weight { get; set; }
        public ApiReference Properties { get; set; } //ApiReference (Weapon_Properties)
        public string Url { get; set; }
    }
}
