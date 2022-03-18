using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    class Rule
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public List<string> Desc { get; set; }
        public ApiReference Subsections { get; set; } //ApiReference (Rule Section)
        public string Url { get; set; }
    }
}
