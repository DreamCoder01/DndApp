using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    public class Choice
    {
        public int Choose { get; set; }
        public string Type { get; set; }
        public List<ApiReference> From { get; set; }
    }
}
