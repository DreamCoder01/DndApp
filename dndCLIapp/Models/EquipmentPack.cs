using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    class EquipmentPack
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public ApiReference Equipment_Category { get; set; } //ApiReference (Equipment Categories)
        public ApiReference Gear_Category { get; set; } //ApiReference (Equipment Categories)
        public Cost Cost { get; set; }
        public List<ApiReference> Contents { get; set; } //ApiReference (Equipment)
        public string Url { get; set; }
    }
}
