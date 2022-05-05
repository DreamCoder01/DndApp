using System;
using System.Collections.Generic;
namespace DndApp.Models
{
    public class StartingEquipmentOptions
    {

        public int Choose { get; set; }
        public string Type { get; set; }
        public Dictionary<StartingEquipment, EquipmentOption> From { get; set; } 
    }
}
