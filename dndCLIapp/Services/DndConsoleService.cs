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
            Console.WriteLine("Ability Bonuses: " + race.AbilityBonus);
            Console.WriteLine("Alignment: " + race.Alignment);
            Console.WriteLine("Age: " + race.Age);
            Console.WriteLine("Size: " + race.Size);
            Console.WriteLine("Size Description: " + race.Size_Description);
            Console.WriteLine("Starting Proficiences: " + race.StartingProficiences);
            Console.WriteLine("Starting Proficience Options: " + race.StartingProficiencesOptions);
            Console.WriteLine("Languages: " + race.Languages);
            Console.WriteLine("Languages Description: " + race.Language_Desc);
            Console.WriteLine("Traits: " + race.Traits);
            Console.WriteLine("Languages: " + race.Languages);
            //Console.WriteLine("Subraces: " + race.Sub);
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
            Console.WriteLine("Name: " + spell.Name);
            Console.WriteLine("Desc: " + spell.Desc);
            Console.WriteLine("Higher Level: " + spell.Higher_Level);
            Console.WriteLine("Range: " + spell.Range);
            Console.WriteLine("Components: " + spell.Components);
            Console.WriteLine("Material: " + spell.Material);
            Console.WriteLine("Ritual: " + spell.Ritual);
            Console.WriteLine("Duration: " + spell.Duration);
            Console.WriteLine("Concentration: " + spell.Concentration);
            Console.WriteLine("Casting Time: " + spell.Casting_Time);
            Console.WriteLine("Level: " + spell.Level);
            Console.WriteLine("Attack Type: " + spell.Attack_Type);
            Console.WriteLine("Damage: " + spell.Damage);
            Console.WriteLine("School: " + spell.School);
            Console.WriteLine("Classes: " + spell.Classes);
            Console.WriteLine("Subclasses: " + spell.Subclasses);
            Console.WriteLine("");
        }

        public Race PromptForAuctionData(Race oldAuction = null)
        {
            /* int id = oldAuction == null ? 0 : oldAuction.Id;
             string title = PromptForString("Auction Title", oldAuction?.Title);
             string description = PromptForString("Description", oldAuction?.Description);
             string user = PromptForString("User", oldAuction?.User);
             double currentBid = PromptForDouble("Current bid", oldAuction?.CurrentBid);

             return new Auction(id, title, description, user, currentBid);*/
            return null;
        }




    }
}
