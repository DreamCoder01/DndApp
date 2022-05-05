using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    public class Class
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public int Hit_Die { get; set; }
        public List<Choice> Proficiency_Choices { get; set; } //List Choice (Proficiencies)
        public List<ApiReference> Proficiencies { get; set; } //ApiReference (Proficiences)
        public List<ApiReference> Saving_Throws { get; set; } //ApiReference (Ability Scores)
        public List<StartingEquipment> Starting_Equipment { get; set; } //Object (Starting Equipment)
        public List<StartingEquipmentOptions> Starting_Equipment_Options { get; set; }
        public string Class_Levels { get; set; } //string (Levels)
        public object Multi_Classing { get; set; } // object (Multi Classing)
        public List<ApiReference> Subclasses { get; set; } //list ApiReference (SubClass)
        public object Spellcasting { get; set; } //object (Spellcasting)
        public string Spells { get; set; } //The URL of the class's spell Resource List. Returns a list of all spells that can be learned or cast by the class.
        public string Url { get; set; }
    }
}
