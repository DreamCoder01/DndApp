using System;
using System.Collections.Generic;
namespace DndApp.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Equipment
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class EquipmentCategoryy
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class From
    {
        public EquipmentCategoryy equipment_category { get; set; }
        public Equipment equipment { get; set; }
        public int quantity { get; set; }
        public EquipmentOptions equipment_option { get; set; }
    }

    public class EquipmentOptions
    {
        public int choose { get; set; }
        public string type { get; set; }
        public From from { get; set; }
    }

    public class StartingEquipmentOption
    {
        public int choose { get; set; }
        public string type { get; set; }
        public List<From> from { get; set; }
    }

    public class Root
    {
        public List<StartingEquipmentOption> starting_equipment_options { get; set; }
    }


}
