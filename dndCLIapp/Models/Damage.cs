using System;
using System.Collections.Generic;
namespace DndApp.Models
{
    public class Damage
    {
        public ApiReference Damage_Type { get; set; }

        public Dictionary<string, string> Damage_At_Slot_Level { get; set; }
    }
}
