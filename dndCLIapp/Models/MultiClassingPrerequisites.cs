using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    class MultiClassingPrerequisites
    {
        public List<object> Prerequisites { get; set; }
        public List<Choice> Prerequisite_Options { get; set; } //List Choice (Prerequisites)
        public List<ApiReference> Proficiencies { get; set; } //List ApiReference (Proficiencies)
        public List<Choice> Proficiency_Choices { get; set; } //List Choice (Proficiencies)
    }
}
