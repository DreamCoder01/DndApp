using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    class Language
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<string> Typical_Speakers { get; set; }
        public string Script { get; set; }
        public string Url { get; set; }
    }
}
