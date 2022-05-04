using DndApp.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace DndApp.Services
{
    public class DndConsoleService : ConsoleService
    {
        /************************************************************
             Print methods
         ************************************************************/
        public void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Menu:");
            Console.WriteLine("1: List all races");
            Console.WriteLine("2: List all spells");
            Console.WriteLine("3: Roll Generator");
            Console.WriteLine("4: Ipsum");
            Console.WriteLine("5: Create a new auction");
            Console.WriteLine("6: Modify an auction");
            Console.WriteLine("7: Delete an auction");
            Console.WriteLine("0: Exit");
            Console.WriteLine("---------");
        }

        public void PrintRaces(List<Race> races)
        {
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Races");
            Console.WriteLine("--------------------------------------------");
            foreach (Race race in races)
            {
                int counter = 0;
                counter++;
                Console.WriteLine($"{counter}: {race.Name}");
            }
            Console.WriteLine("");
        }
        public void PrintRaceList(List<ApiReference> races)
        {
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Races");
            Console.WriteLine("--------------------------------------------");
            int counter = 0;
            foreach (ApiReference race in races)
            {
                counter++;
                Console.WriteLine($"{counter}: {race.Name}");
            }
            Console.WriteLine("");
        }

        public void PrintRace(Race race)
        {
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Race Details");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Name: " + race.Name);
            Console.WriteLine("Speed: " + race.Speed);
            Console.WriteLine("Ability Bonuses: ");
            PrintAbilityBonuses(race.Ability_Bonuses);
            Console.WriteLine("Alignment: " + race.Alignment);
            Console.WriteLine("Age: " + race.Age);
            Console.WriteLine("Size: " + race.Size);
            Console.WriteLine("Size Description: " + race.Size_Description);
            Console.WriteLine("Starting Proficiences: ");
            PrintApiReference(race.Starting_Proficiences);
            if (race.Starting_Proficiency_Options != null)
            {
                Console.WriteLine("Starting Proficience Options: ");
                PrintChoice(race.Starting_Proficiency_Options);
            }
            Console.WriteLine("Languages: ");
            PrintApiReference(race.Languages);
            Console.WriteLine("Languages Description: " + race.Language_Desc);
            if (race.Language_Options != null)
            {
                Console.WriteLine("Language Options: ");
                PrintChoice(race.Language_Options);
            }
            Console.WriteLine("Traits: ");
            PrintApiReference(race.Traits);
            Console.WriteLine("Subraces: ");
            PrintApiReference(race.Subraces);
            Console.WriteLine("");
        }

        public void PrintSpells(List<Spell> spells)
        {
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Spells");
            Console.WriteLine("--------------------------------------------");
            foreach (Spell spell in spells)
            {
                int counter = 0;
                counter++;
                Console.WriteLine($"{counter}: {spell.Name}");
            }
            Console.WriteLine("");
        }
        public void PrintSpellList(List<ApiReference> spells)
        {
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Spells");
            Console.WriteLine("--------------------------------------------");
            int counter = 0;
            foreach (ApiReference spell in spells)
            {
                counter++;
                Console.WriteLine($"{counter}: {spell.Name}");
            }
            Console.WriteLine("");
        }

        public void PrintSpell(Spell spell)
        {
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Spell Details");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(spell.Name);
            PrintSpellLevel(spell);
            Console.WriteLine("");
            Console.WriteLine("Casting Time: " + spell.Casting_Time);
            if(spell.Attack_Type != null)
            {
                Console.WriteLine("Attack-Type: " + spell.Attack_Type);
            }
            Console.WriteLine("Range: " + spell.Range);
            Console.Write("Components: ");
            PrintComponents(spell);
            if (spell.Material != null)
            {
                Console.Write($"({spell.Material})");
            }
            Console.WriteLine("");
            PrintSpellDuration(spell);
            Console.WriteLine("");
            Console.Write("Description: ");
            PrintListString(spell.Desc);
            Console.WriteLine("");
            if (spell.Higher_Level.Count > 0)
            {
                Console.Write("At Higher Levels: ");
                PrintListString(spell.Higher_Level);
                Console.WriteLine("");
            }
            if (spell.Damage != null)
            {
                Console.WriteLine("💥Damage💥 ");
                PrintDamages(spell);
            }
            if (spell.Heal != null)
            {
                Console.WriteLine("❤️‍🩹Heal At Slot Level❤️‍🩹");
                PrintHealAtSlotLevel(spell);
            }
            Console.WriteLine("Classes: ");
            PrintApiReference(spell.Classes);
            if (spell.Subclasses != null)
            {
                Console.WriteLine("Subclasses: ");
                PrintApiReference(spell.Subclasses);
            }
            
            Console.WriteLine("");
        }

        public void PrintAbilityBonuses(List<AbilityBonus> abilityBonuses)
        {
            foreach (AbilityBonus ab in abilityBonuses)
            {
                Console.WriteLine($"+{ab.Bonus} {ab.Ability_Score.Name}");
            }
        }

        public void PrintApiReference(List<ApiReference> listApi)
        {
            int counter = 0;
            if (listApi == null || listApi.Count == 0)
            {
                Console.WriteLine("none");
            }
            else
            {
                foreach (ApiReference apir in listApi)
                {
                    counter++;
                    Console.WriteLine($"  {counter}: {apir}");
                }
                Console.WriteLine("");
            }
        }

        public void PrintChoice(Choice choice)
        {
            if (choice != null)
            {
                Console.WriteLine($"Choose {choice.Choose} from the following {choice.Type}: ");
                PrintApiReference(choice.From);
            }
        }

        public void PrintComponents(Spell spell)
        {
            if (spell != null)
            {
                foreach (string str in spell.Components)
                {
                    Console.Write($"{str}, ");
                }
            }
        }

        public void PrintListString(List<string> strings)
        {
            if (strings != null)
            {
                foreach (string str in strings)
                {
                    Console.WriteLine($"{str}");
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }
        }

        public void PrintSpellLevel(Spell spell)
        {
            if(spell.Level == 1 && spell.Ritual == true)
            {
                Console.WriteLine($"{spell.Level}st-level {spell.School.Name} (ritual)");
            }
            else if (spell.Level == 1 && spell.Ritual == false)
            {
                Console.WriteLine($"{spell.Level}st-level {spell.School.Name}");
            }
            else if (spell.Level == 2 && spell.Ritual == true)
            {
                Console.WriteLine($"{spell.Level}nd-level {spell.School.Name} (ritual)");
            }
            else if (spell.Level == 2 && spell.Ritual == false)
            {
                Console.WriteLine($"{spell.Level}nd-level {spell.School.Name}");
            }
            else if (spell.Level == 3 && spell.Ritual == true)
            {
                Console.WriteLine($"{spell.Level}rd-level {spell.School.Name} (ritual)");
            }
            else if (spell.Level == 3 && spell.Ritual == false)
            {
                Console.WriteLine($"{spell.Level}rd-level {spell.School.Name}");
            }
            else if (spell.Level >= 4 && spell.Ritual == true)
            {
                Console.WriteLine($"{spell.Level}th-level {spell.School.Name} (ritual)");
            }
            else if (spell.Level >= 4 && spell.Ritual == false)
            {
                Console.WriteLine($"{spell.Level}th-level {spell.School.Name}");
            }
        }

        public void PrintSpellDuration(Spell spell)
        {
            if(spell.Concentration == true)
            {
                Console.WriteLine($"Duration: Concentration, {spell.Duration}");
            }
            else if(spell.Concentration == false)
            {
                Console.WriteLine($"Duration: {spell.Duration}");
            }
        }

        public void PrintDamages(Spell spell)
        {
            if (spell.Damage != null)
            {
                if(spell.Damage.Damage_Type.Name == "Acid")
                {
                    Console.WriteLine($"🦫Damage-Type: {spell.Damage.Damage_Type} 🧬");
                }
                else if (spell.Damage.Damage_Type.Name == "Bludgeoning")
                {
                    Console.WriteLine($"🦫Damage-Type: {spell.Damage.Damage_Type} 🔨");
                }
                else if (spell.Damage.Damage_Type.Name == "Cold")
                {
                    Console.WriteLine($"🦫Damage-Type: {spell.Damage.Damage_Type} ❄️");
                }
                else if (spell.Damage.Damage_Type.Name == "Fire")
                {
                    Console.WriteLine($"🦫Damage-Type: {spell.Damage.Damage_Type} 🔥");
                }
                else if (spell.Damage.Damage_Type.Name == "Force")
                {
                    Console.WriteLine($"🦫Damage-Type: {spell.Damage.Damage_Type} 🪄");
                }
                else if (spell.Damage.Damage_Type.Name == "Lightning")
                {
                    Console.WriteLine($"🦫Damage-Type: {spell.Damage.Damage_Type} ⚡️");
                }
                else if (spell.Damage.Damage_Type.Name == "Necrotic")
                {
                    Console.WriteLine($"🦫Damage-Type: {spell.Damage.Damage_Type} 🧟‍♂️");
                }
                else if (spell.Damage.Damage_Type.Name == "Piercing")
                {
                    Console.WriteLine($"🦫Damage-Type: {spell.Damage.Damage_Type} 🤺");
                }
                else if (spell.Damage.Damage_Type.Name == "Poison")
                {
                    Console.WriteLine($"🦫Damage-Type: {spell.Damage.Damage_Type} ☠️");
                }
                else if (spell.Damage.Damage_Type.Name == "Psychic")
                {
                    Console.WriteLine($"🦫Damage-Type: {spell.Damage.Damage_Type} 🔮");
                }
                else if (spell.Damage.Damage_Type.Name == "Radiant")
                {
                    Console.WriteLine($"🦫Damage-Type: {spell.Damage.Damage_Type} ✨");
                }
                else if (spell.Damage.Damage_Type.Name == "Slashing")
                {
                    Console.WriteLine($"🦫Damage-Type: {spell.Damage.Damage_Type} ⚔️");
                }
                else if (spell.Damage.Damage_Type.Name == "Thunder")
                {
                    Console.WriteLine($"🦫Damage-Type: {spell.Damage.Damage_Type} 🌩");
                }

                Console.WriteLine($"⭐️Damage By Slot-Level ");
                foreach(KeyValuePair<string, string> kvp in spell.Damage.Damage_At_Slot_Level)
                {
                    Console.WriteLine($"  {kvp.Key}: {kvp.Value}");
                }
                Console.WriteLine("");   
            }
        }

        public void PrintHealAtSlotLevel(Spell spell)
        {
            if (spell.Heal != null)
            {
                foreach(KeyValuePair<string, string> kvp in spell.Heal.HealAtSlotLevel)
                {
                    Console.WriteLine($"  {kvp.Key}: {kvp.Value}");
                }
            }
        }
    }
}
