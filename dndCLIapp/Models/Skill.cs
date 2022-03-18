using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    class Skill
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public List<string> Desc { get; set; }
        public ApiReference Ability_Score { get; set; }//APIReference (Ability Score)
        public string Url { get; set; }

    }
}
