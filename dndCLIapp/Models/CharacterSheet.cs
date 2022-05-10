using System;
using System.Collections.Generic;
namespace DndApp.Models
{
    public class CharacterSheet
    {
        public int id { get; set; }
        public string CharacterName { get; set; }
        public object PlayerName { get; set; }
        public User user { get; set; }
        public int Level { get; set; }
        public Race race { get; set; }
        public Subrace subrace { get; set; }
        public Class _class { get; set; }
        public Subclass subclass { get; set; }
        public Background background { get; set; }
        public Alignment alignment { get; set; }
        public int ExperiencePoints { get; set; }
        public int ArmorClass { get; set; }
        public int initiative { get; set; }
        public int speed { get; set; }
        public List<Skill> skills { get; set; }
        public List<AbilityScore> abilities { get; set; }


    }
}
