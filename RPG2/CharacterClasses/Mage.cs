using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2.CharacterClasses
{
    class Mage : Entity
    {
        public Mage()
            : base()
        {
            Strength = 8;
            Dexterity = 12;
            Wisdom = 15;
            Health = 12;
        }
    }
}
