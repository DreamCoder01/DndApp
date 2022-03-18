using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    class Feature
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public ApiReference Class { get; set; } //ApiReference (Class)
        public ApiReference Subclass { get; set; } //ApiReference (Subclass)
        public List<string> Desc { get; set; }
        public FeatureSpecific Feature_Specific{ get; set; }
        public string Url { get; set; }
    }
}
