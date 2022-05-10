using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    public class Subclass
    {
        public string Index { get; set; }
        public ApiReference Class { get; set; } //ApiReference (Class)
        public string Name { get; set; } 
        public string Subclass_Flavor { get; set; }
        public List<string> Desc { get; set; }
        public List<Spell> Spell { get; set; } //????????? List of Spell or string????????? Also all other occurences in Api where datatype is list
        public string Subclasses_Levels { get; set; }
        public string Url { get; set; }
    }
}
