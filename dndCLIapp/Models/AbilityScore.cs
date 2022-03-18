using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    class AbilityScore
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public string Full_Name { get; set; }
        public List<string> Desc { get; set; }
        public List<ApiReference> Skills { get; set; }
        public string Url { get; set; }

    }
}
