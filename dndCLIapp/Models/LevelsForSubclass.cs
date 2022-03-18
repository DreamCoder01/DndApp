using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    class LevelsForSubclass
    {
        public string Index { get; set; }
        public int Level { get; set; }
        public List<ApiReference> Features { get; set; } //List ApiReference (Features)
        public ApiReference Class { get; set; } //ApiReference (Class) Updated ability scores, classes, and conditions
        public ApiReference Subclass { get; set; } // ApiReference (Subclass)
        public string Url { get; set; }
    }
}
