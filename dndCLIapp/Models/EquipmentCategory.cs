using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    class EquipmentCategory
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public List<ApiReference> Equipment { get; set; } //List ApiReference (Equipment)
    }
}
