using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2.CharacterClasses
{
    public enum EntityGender { Male, Female, Unknown }
    //TODO add enum for character classes.
    //This is template for all characters including NPC's
    public abstract class Entity
    {
        #region Fields Regions
        protected Random rand;
        protected string _name;
        protected EntityGender _gender;
        protected int _strength;
        protected int _dexterity;
        protected int _wisdom;
        protected int _health;
        protected int _strengthModifier;
        protected int _dexterityModifier;
        protected int _wisdomModifier;
        protected int _healthModifier;
        #endregion

        #region Properties Region
        public string Name
        {
            get { return _name; }
            protected set { _name = value; }
        }
        public EntityGender Gender
        {
            get { return _gender; }
            protected set { _gender = value; }
        }
        public int Strength
        {
            get { return _strength + _strengthModifier; }
            protected set { _strength = value; }
        }
        public int Dexterity
        {
            get { return _dexterity + _dexterityModifier; }
            protected set { _dexterity = value; }
        }
        public int Wisdom
        {
            get { return _wisdom + _wisdomModifier; }
            protected set { _wisdom = value; }
        }

        public int Health
        {
            get { return _health + _healthModifier; }
            protected set { _health = value; }
        }

  

        #endregion

        #region Constructor Region
        public Entity()
        {
            Name = "";
            Strength = 0;
            Dexterity = 0;
            Wisdom = 0;
            Health = 0;
        }
        #endregion

        #region Methods Region

        #endregion

    }
}

