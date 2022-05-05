using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    public class EquipmentCategory
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public ApiReference Equipment { get; set; } //List ApiReference (Equipment)
    }
}
