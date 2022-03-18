using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    public class Race
    {
        //race details or race expanded
        public string Index { get; set; }
        public string Name { get; set; }
        public int Speed { get; set; }
        public string AbilityBonus { get; set; }
        public string Alignment { get; set; }
        public string Age { get; set; }
        public string Size { get; set; }
        public string Size_Description { get; set; }
        public string StartingProficiences { get; set; }
        public string StartingProficiencesOptions { get; set; }
        public List<ApiReference> Languages { get; set; }
        public string Language_Desc { get; set; }
        public List<ApiReference> Traits { get; set; }
        //public string SubRaces { get; set; }//actually a list of objects/url/ start with pulling into string format// refactor pulling json objects // another api call with uri // 

       /* public RaceDetail(string index, string name, int speed, string abilityBonus, string alignment, int age, string size, string sizeDescription, string startingProficiences, string startingProficiencesOptions, string languages, string languagesDescription, string traits, string subRaces)
        {
            Index = index;
            Name = name;
            Speed = speed;
            AbilityBonus = abilityBonus;
            Alignment = alignment;
            Age = age;
            Size = size;
            SizeDescription = sizeDescription;
            StartingProficiences = startingProficiences;
            StartingProficiencesOptions = startingProficiencesOptions;
            Languages = languages;
            LanguagesDescription = languagesDescription;
            Traits = traits;
            SubRaces = subRaces;
        }*/

        




        //this code should be inherited or built using API
        //need a base class Race for below properties, or an interface, or abstract class, or model class

        //Make a race model, make race mehtods for individual races, build race by selecting name
        //https://www.dnd5eapi.co/api/


        //could be either a game or an app to store your character builds from 5e
        //overall goal is to be able to access all info for Character Data, Race, Class, Backgrounds, Equipment, Spells, Feats, Armor, HP, etc
        //Should be able to select from the above to set-up a custom character, and save/log character stats, update stats(e.g. xp, current level, etc.), current loot, weight, food, equipment etc.
        //Next add a monster 'library' that can choose a monster(s) based on level
        //If text based game, software acts as DM, narrator, referee
        //if game, need to write out story, npc dialogue and actions, locations, monsters, battle scenes
        //rolling of dice, physical or virtual? which die for which scenario, how many dice, etc.
        //create NPC's for adventure party --found 5 premade character sheets, Can use to preprogram optional party members
        //create a library of NPC's
        //create a library of one-shot adventures/ or just start with one
        //calculate movement speed, distance, on a grid-map for battles
        //create turn order based on roll of initiative
        //create a map of battle scene with character/npc/monster locations?
        //factor in advantage/disadvantage for rolls character/monster
        //factor inspiration points?
        //character dialogue multiple choice with multiple responses from npc's/ affect the overall development of story/location/mission
        //resting, meditating, potions, magical items, creatures, companions, 
        //GAME MECHANICS
        //RULES
    }


}
