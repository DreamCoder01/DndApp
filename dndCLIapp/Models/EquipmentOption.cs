using System;
namespace DndApp.Models
{
    public class EquipmentOption
    {
        public int Choose { get; set; }
        public string Type { get; set; }
        public EquipmentCategory From { get; set; }
    }
}
