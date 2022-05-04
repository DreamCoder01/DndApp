using System;
using System.Collections.Generic;
namespace DndApp.Models
{
    public class AbilityBonusOptions
    {
        public int Choose { get; set; }
        public string Type { get; set; }
        public List<AbilityBonus> From { get; set; }
    }
}
