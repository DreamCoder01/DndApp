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
                    // Create a new auction
                    AddAuction();
                }

                if (menuSelection == 6)
                {
                    // Modify an auction
                    UpdateAuction();
                }

                if (menuSelection == 7)
                {
                    // Delete an auction
                    DeleteAuction();
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

        private void ShowAuctionsBelowPrice()
        {
            /*try
            {
                double searchPrice = console.PromptForDouble("Please enter a max price to search for");
                List<Auction> auctions = auctionApiService.GetAuctionsSearchPrice(searchPrice);
                console.PrintAuctions(auctions);
            }
            catch (Exception ex)
            {
                console.PrintError(ex.Message);
            }
            console.Pause();*/
        }

        private void AddAuction()
        {
            /*Auction auctionToAdd = console.PromptForAuctionData();
            if (auctionToAdd.IsValid)
            {


                try
                {
                    Auction addedAuction = auctionApiService.AddAuction(auctionToAdd);
                    if (addedAuction != null)
                    {
                        console.PrintSuccess($"Auction {addedAuction.Id} successfully added.");
                    }
                    else
                    {
                        console.PrintError("Auction not added.");
                    }
                }
                catch (Exception ex)
                {
                    console.PrintError(ex.Message);
                }
            }
            else
            {
                console.PrintError("Invalid data");
            }
            console.Pause();*/
        }

        private void UpdateAuction()
        {
            // Update an existing auction
            /*try
            {
                List<Auction> auctions = auctionApiService.GetAllAuctions();
                if (auctions != null)
                {
                    int auctionId = console.PromptForAuctionId(auctions, "update");
                    if (auctionId == 0)
                    {
                        // User cancel
                        return;
                    }

                    Auction oldAuction = auctionApiService.GetDetailsForAuction(auctionId);
                    if (oldAuction != null)
                    {
                        Auction auctionToUpdate = console.PromptForAuctionData(oldAuction);
                        if (auctionToUpdate.IsValid)
                        {
                            Auction updatedAuction = auctionApiService.UpdateAuction(auctionToUpdate);
                            if (updatedAuction != null)
                            {
                                console.PrintSuccess("Auction successfully updated.");
                            }
                            else
                            {
                                console.PrintError("Auction not updated.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                console.PrintError(ex.Message);
            }
            console.Pause();*/
        }

        private void DeleteAuction()
        {
            // Delete auction
            /*try
            {
                List<Auction> auctions = auctionApiService.GetAllAuctions();
                if (auctions != null)
                {
                    int auctionId = console.PromptForAuctionId(auctions, "delete");
                    if (auctionId == 0)
                    {
                        // User cancel
                        return;
                    }

                    bool deleteSuccess = auctionApiService.DeleteAuction(auctionId);
                    if (deleteSuccess)
                    {
                        console.PrintSuccess("Auction successfully deleted.");
                    }
                    else
                    {
                        console.PrintError("Auction not deleted.");
                    }
                }
            }
            catch (Exception ex)
            {
                console.PrintError(ex.Message);
            }
            console.Pause();*/
        }
    }
}
