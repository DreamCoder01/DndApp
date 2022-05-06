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
        public List<ProficiencyChoice> Proficiency_Choices { get; set; } //List Choice (Proficiencies)
        public List<ApiReference> Proficiencies { get; set; } //ApiReference (Proficiences)
        public List<ApiReference> Saving_Throws { get; set; } //ApiReference (Ability Scores)
        public List<StartingEquipment> Starting_Equipment { get; set; } //Object (Starting Equipment)
        public List<StartingEquipmentOption> Starting_Equipment_Options { get; set; } //A list of a list of choices?
        public string Class_Levels { get; set; } //string (Levels)
        public MultiClassing Multi_Classing { get; set; } // object (Multi Classing)
        public List<ApiReference> Subclasses { get; set; } //list ApiReference (SubClass)
        public Spellcasting spellcasting { get; set; } //object (Spellcasting)
        public string Spells { get; set; } //The URL of the class's spell Resource List. Returns a list of all spells that can be learned or cast by the class.
        public string Url { get; set; }
    }

    public class _0
    {
        public ApiReference equipment { get; set; }
        public int quantity { get; set; }
    }

    public class _1
    {
        public ApiReference equipment { get; set; }
        public int quantity { get; set; }
        public EquipmentOption equipment_option { get; set; }
    }

    public class _2
    {
        public ApiReference equipment { get; set; }
        public int quantity { get; set; }
    }


    public class EquipmentOption
    {
        public int choose { get; set; }
        public string type { get; set; }
        public From from { get; set; }
    }

    public class From
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public int quantity { get; set; }
        public List<Prerequisite> prerequisites { get; set; }
        public _0 _0 { get; set; }
        public _1 _1 { get; set; }
        public _2 _2 { get; set; }
        public ApiReference equipment { get; set; }
        public EquipmentOption equipment_option { get; set; }
        public ApiReference equipment_category { get; set; }
        public ApiReference ability_score { get; set; }
        public int minimum_score { get; set; }
    }

    public class Info
    {
        public string name { get; set; }
        public List<string> desc { get; set; }
    }

    public class MultiClassing
    {
        public PrerequisiteOptions prerequisite_options { get; set; }
        public List<Prerequisite> prerequisites { get; set; }
        public List<ApiReference> proficiencies { get; set; }
        public List<ProficiencyChoice> proficiency_choices { get; set; }
    }

    public class Prerequisite
    {
        public string type { get; set; }
        public ApiReference proficiency { get; set; }
        public ApiReference ability_score { get; set; }
        public int minimum_score { get; set; }
    }

    public class PrerequisiteOptions
    {
        public string type { get; set; }
        public int choose { get; set; }
        public List<From> from { get; set; }
    }


    public class ProficiencyChoice
    {
        public int choose { get; set; }
        public string type { get; set; }
        public List<From> from { get; set; }
    }

    public class Spellcasting
    {
        public int level { get; set; }
        public ApiReference spellcasting_ability { get; set; }
        public List<Info> info { get; set; }
    }

    public class StartingEquipment
    {
        public ApiReference equipment { get; set; }
        public int quantity { get; set; }
    }

    public class StartingEquipmentOption
    {
        public int choose { get; set; }
        public string type { get; set; }
        public List<From> from { get; set; }
    }

    

}
