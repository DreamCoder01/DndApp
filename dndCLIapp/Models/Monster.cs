using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    class Monster
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public string Subtype { get; set; }
        public string Alignment { get; set; }
        public int Armor_Class { get; set; }
        public int Hit_Points { get; set; }
        public string Hit_Dice { get; set; }
        public ApiReference Forms { get; set; } //ApiReference (Monsters)
        public object Speed { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public List<ApiReference> Proficiencies { get; set; }
        public List<string> Damage_Vulnerabilities { get; set; } //undefined list
        public List<string> Damage_Resistances { get; set; } //undefined list
        public List<string> Damage_Immunities { get; set; } //undefined list
        public List<string> Condition_Immunities { get; set; } //undefined list
        public object Senses { get; set; }
        public string Languages { get; set; }
        public int Challenge_Rating { get; set; } //A monster's challenge rating is a guideline number that says when a monster becomes an appropriate challenge against the party's average level. For example. A group of 4 players with an average level of 4 would have an appropriate combat challenge against a monster with a challenge rating of 4 but a monster with a challenge rating of 8 against the same group of players would pose a significant threat.
        public List<string> Special_Abilities { get; set; } //undefined list
        public List<string> Actions { get; set; } //undefined list
        public List<string> Legendary_Actions { get; set; } //undefined list
        public string Url { get; set; }
    }
}
