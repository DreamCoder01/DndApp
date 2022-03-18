using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    class Trait
    {
        public string Index { get; set; }
        public List<ApiReference> Race { get; set; } //Proficiencies
        public List<ApiReference> Subrace { get; set; } //Proficiencies
        public string Name { get; set; }
        public List<string> Desc { get; set; }
        public ApiReference Proficiencies { get; set; } // Proficiencies
        public Choice Proficiency_Choices { get; set; } // Choice (Proficiencies)
        public TraitSpecific Trait_Specific { get; set; }
        public string Url { get; set; }
    }
}
