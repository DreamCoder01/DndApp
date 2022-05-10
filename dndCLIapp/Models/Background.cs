using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    public class Background//Api only has Acolyte -- Need more backgrounds?
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public List<ApiReference> Starting_Proficiencies { get; set; } //List ApiReference (Proficiencies)
        public Choice Language_Options { get; set; } //Choice (Languages)
        public List<ApiReference> Starting_Equipment { get; set; } //List ApiReference (Equipment)
        public List<Choice> Starting_Equipment_Options { get; set; } //List Choice (Equipment)


        public /*BackgroundFeature*/ object Feature { get; set; }//BackgroundFeature not defined!!!!!!!!!!!!!***************************************************************
        public Choice Personality_Traits { get; set; } //Choice (string)
        public Choice Ideals { get; set; } //Choice (Ideal) //desc, alignments-list
        public Choice Bonds { get; set; } //Choice (string)
        public Choice Flaws { get; set; } //Choice (string)
        public string Url { get; set; }
    }
}
