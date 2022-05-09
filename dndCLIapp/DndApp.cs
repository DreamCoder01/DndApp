using DndApp.Services;
using DndApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using System.Net.Http;

namespace DndApp
{
    
    public class DndApp
    {
        private readonly DndApiService dndApiService;
        private readonly DndConsoleService console = new DndConsoleService();
        private List<ApiReference> AllRaces = new List<ApiReference>();
        private List<ApiReference> AllSpells = new List<ApiReference>();
        private List<ApiReference> AllClasses = new List<ApiReference>();
        private RollGenerator rollGenerator = new RollGenerator();
        public DndApp(string apiUrl)
        {
            this.dndApiService = new DndApiService(apiUrl);
        }

        public void Run()
        {
            while (true)
            {
                console.PrintMainMenu();
                int menuSelection = console.PromptForInteger("Please choose an option", 0, 7);

                if (menuSelection == 0)
                {
                    // Exit the loop
                    break;
                }

                if (menuSelection == 1)
                {
                    // List auctions
                    ShowRaces();
                }

                if (menuSelection == 2)
                {
                    // Show a single auction
                    ShowSpells();
                }

                if (menuSelection == 3)
                {
                    // Search for auctions with a term
                    RollDice();
                }

                if (menuSelection == 4)
                {
                    // Search for auctions below a price
                    ShowClasses();
                }

                if (menuSelection == 5)
                {
                    ShowSpellsByClassLevel();
                }

                if (menuSelection == 6)
                {
                    
                }

                if (menuSelection == 7)
                {
                    
                }
            }
        }

        private void ShowRaces()
        {
            try
            {
                AllRaces = dndApiService.DisplayRaceList();
                console.PrintRaceList(AllRaces);
                int menuSelection = console.PromptForInteger("Please choose a race", 1, AllRaces.Count);
                
                Race race = dndApiService.GetRaceDetail(AllRaces[menuSelection - 1].Url);
                console.PrintRace(race);
            }
            catch (Exception ex)
            {
                console.PrintError(ex.Message);
            }
            console.Pause();
        }

        private void ShowClasses()
        {
            try
            {
                AllClasses = dndApiService.DisplayClassList();
                console.PrintClassList(AllClasses);
                int menuSelection = console.PromptForInteger("Please choose a class", 1, AllClasses.Count);

                Class classy = dndApiService.GetClassDetail(AllClasses[menuSelection - 1].Url);
                console.PrintClass(classy);
            }
            catch (Exception ex)
            {
                console.PrintError(ex.Message);
            }
            console.Pause();
        }

        private void ShowSpells()
        {
            try
            {
                AllSpells = dndApiService.DisplaySpellList();
                console.PrintSpellList(AllSpells);
                int menuSelection = console.PromptForInteger("Please choose a spell", 1, AllSpells.Count);

                Spell spell = dndApiService.GetSpellDetail(AllSpells[menuSelection - 1].Url);
                console.PrintSpell(spell);
            }
            catch (Exception ex)
            {
                console.PrintError(ex.Message);
            }
            console.Pause();
        }

        private void ShowSpellsByClassLevel()
        {
            try
            {
                AllSpells = dndApiService.DisplaySpellList();
                Spell spell = new Spell();
                List<Spell> allSpellDetails = new List<Spell>();

                foreach (ApiReference apir in AllSpells)
                {
                    spell = dndApiService.GetSpellDetail(apir.Url);
                    allSpellDetails.Add(spell);
                }

                console.PrintSpellByClassLevel(allSpellDetails);
            }
            catch (Exception ex)
            {
                console.PrintError(ex.Message);
            }
            console.Pause();
        }

        private void RollDice()
        {
            try
            {
                //user can input max value != valid die
                bool validInput = false;
                while (!validInput)
                {
                    string dX = console.PromptForString("Please enter max value of die (d20 = 20)");
                    int MaxValue = int.Parse(dX);
                    if (MaxValue != 2 && MaxValue != 3 && MaxValue != 4 && MaxValue != 6 && MaxValue != 8 && MaxValue != 10 && MaxValue != 12 && MaxValue != 20 && MaxValue != 100)
                    {
                        validInput = false;
                        Console.WriteLine("\n==============Invalid input!==================\n");
                        Console.Beep();
                    }
                    else
                    {
                        validInput = true;
                        string Xd = console.PromptForString("Please enter the number of dice (4d6 = 4)");
                        int numberOfDice = int.Parse(Xd);
                        Console.WriteLine($"Roll result: {rollGenerator.RollGen(MaxValue, numberOfDice)}");
                        Console.WriteLine("");
                    }
                }  
            }
            catch (Exception ex)
            {
                console.PrintError(ex.Message);
            }
            console.Pause();
        }
    }
}
