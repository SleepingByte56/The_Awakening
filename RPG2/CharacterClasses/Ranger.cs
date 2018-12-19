using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2.CharacterClasses
{
    class Ranger : Entity
    {
        public Ranger()
            : base()
        {
            Strength = 15;
            Dexterity = 18;
            Wisdom = 18;
            Health = 20;
        }
    }
}
