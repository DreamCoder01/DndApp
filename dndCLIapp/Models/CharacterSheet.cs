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
        public List<AbilityScore> SavingThrows { get; set; }
        public int currentHP { get; set; }
        public int temporaryHP { get; set; }
        public int hitDice { get; set; }
        public string PersonalityTraits { get; set; }
        public string Ideals { get; set; }
        public string Bonds { get; set; }
        public string Flaws { get; set; }
        public Skill passiveWisdom { get; set; }//perception
        public string Features { get; set; }
        public string Traits { get; set; }
        public string Proficiencies { get; set; }
        public string Languages { get; set; }
        public string attacks { get; set; }
        public string spellcasting { get; set; }
        public string coinPurse { get; set; }
        public Dictionary<string, string> treasure { get; set; }
        public List<EquipmentPack> equipment { get; set; }

        public string CharacterAppearance { get; set; }
        public string Backstory { get; set; }
        public List<string> Allies { get; set; }
        public string Symbol { get; set; }
        public string SpellcastingClass { get; set; }
        public string SpellcastingAbility { get; set; }
        public int SpellSaveDC {get;set;}
        public int SpellAttackBonus { get; set; }
        public List<Spell> SpellsByLevel { get; set; }

    }
}
