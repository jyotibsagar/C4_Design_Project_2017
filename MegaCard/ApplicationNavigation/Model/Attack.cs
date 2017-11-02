//Implementation of class attack
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ApplicationNavigation.Helpers;

namespace ApplicationNavigation.Model
{


    public abstract class Attack
    {

        private int attackBaseDamage;

        public Attack()
        {

        }

        ~Attack()
        {

        }

        /// 
        /// <param name="characterBaseDamage"></param>
        public Attack(int characterBaseDamage)
        {

        }

        /// <summary>
        /// This function will use polymorphism
        /// </summary>
        /// <param name="Character"></param>
        public int MakeAttack(Character Character)
        {

            return 0;
        }


        public void DealDamage(int damage, Character character)
        {
            if (character.GetType() == typeof(PlayerCharacter))
            {
                GameController.Player.currentHealthPoints = GameController.Player.currentHealthPoints - damage;
            }

            if (character.GetType() == typeof(NonPlayerCharacter))
            {
                GameController.Enemy.currentHealthPoints = GameController.Enemy.currentHealthPoints - damage;
            }
        }

    }//end Attack

}