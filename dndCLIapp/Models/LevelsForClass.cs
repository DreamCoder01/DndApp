using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    class LevelsForClass
    {
        public string Index { get; set; }
        public int Level { get; set; }
        public int Ability_Score_Bonuses { get; set; }
        public int Prof_Bonus { get; set; }
        public List<ApiReference> Features { get; set; } //List ApiReference (Features)
        public object Spellcasting { get; set; }
        public object Class_Specific { get; set; }
        public ApiReference Class { get; set; } //ApiReference (Class) Updated ability scores, classes, and conditions
        public string Url { get; set; }
    }
}
