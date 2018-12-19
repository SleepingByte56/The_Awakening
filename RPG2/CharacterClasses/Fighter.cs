using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2.CharacterClasses
{
    public class Fighter : Entity
    {
        public Fighter(string name, EntityGender gender)
            : base()
        {
            Name = name;
            Gender = gender;
            _strength = rand.Next(3, 8);
        }
        public Fighter(string name, EntityGender gender, int strength,
            int dexterity, int wisdom, int health)
        {
            _name = name;
            _gender = gender;
            _strength = strength;
            _dexterity = dexterity;
            _wisdom = wisdom;
            _health = health;
        }
    }
}
