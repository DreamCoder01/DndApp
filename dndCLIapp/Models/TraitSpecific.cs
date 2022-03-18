using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    class TraitSpecific
    {
        public Choice Subtrait_Options { get; set; } //Traits
        public Choice Spell_Options { get; set; } //Spells
        public ApiReference Damage_Type { get; set; } //ApiReference DamageType
        public object Breath_Weapon { get; set; }
    }
}
