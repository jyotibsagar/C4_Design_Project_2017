///////////////////////////////////////////////////////////
//  Character.cs
//  Implementation of the Class Character
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ApplicationNavigation.Model
{


    public abstract class Character
    {
        public NormalAttack attack;
        public int baseDamage;
        public int currentHealthPoints;
        public int maxHealthPoints;

        public Character()
        {

        }

        ~Character()
        {

        }

        /// 
        /// <param name="baseDamage"></param>
        /// <param name="currentHealthPoints"></param>
        /// <param name="maxHealthPoints"></param>
        public Character(int baseDamage, int currentHealthPoints, int maxHealthPoints)
        {

        }

        /// 
        /// <param name="character"></param>
        public void Attack(Character character)
        {

        }

    }//end Character

}