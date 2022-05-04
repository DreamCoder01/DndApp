using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    public class AbilityBonus
    {
        public int Bonus { get; set; }
        public ApiReference Ability_Score { get; set; }
    }
}
