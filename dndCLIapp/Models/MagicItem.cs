using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    class MagicItem
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public ApiReference Equipment_Category { get; set; } //ApiReference (Equipment Categories)
        public List<string> Desc { get; set; }
    }
}
