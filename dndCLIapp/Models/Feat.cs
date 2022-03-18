using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    class Feat
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public List<object> Prerequisites { get; set; }
        public List<string> Desc { get; set; }
        public string Url { get; set; }
    }
}
