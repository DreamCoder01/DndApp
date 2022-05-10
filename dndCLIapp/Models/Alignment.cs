using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
   public class Alignment
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public List<string> Desc { get; set; }
        public string Url { get; set; }
    }
}
