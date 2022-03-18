using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    class Subrace
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public ApiReference Race { get; set; } //ApiReference (Race)
        public string Desc { get; set; }
        public List<AbilityBonus> Ability_Bonuses { get; set; }
        public string StartingProficiences { get; set; }
        public List<ApiReference> Languages { get; set; }
        public Choice Language_Options { get; set; }
        public List<ApiReference> Racial_Traits { get; set; } //Traits
        public string Url { get; set; }
    }
}
