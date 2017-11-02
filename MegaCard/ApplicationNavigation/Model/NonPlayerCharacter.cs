///////////////////////////////////////////////////////////
//  NonPlayerCharacter.cs
//  Implementation of the Class NonPlayerCharacter
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Media.Imaging;
using ApplicationNavigation.Helpers;

namespace ApplicationNavigation.Model
{


    public class NonPlayerCharacter : Character
    {

        
        /// <summary>
        /// e.g. goblin, giant etc
        /// </summary>
        private String enemyType;
        

        public NonPlayerCharacter()
        {

        }

        ~NonPlayerCharacter()
        {

        }

        /// 
        /// <param name="baseDamage"></param>
        /// <param name="currentHealthPoint"></param>
        /// <param name="maxHealthPoints"></param>
        /// <param name="enemyType"></param>
        public NonPlayerCharacter(int baseDamage, int currentHealthPoint, int maxHealthPoints, char enemyType)
        {

        }

        /// 
        /// <param name="Player"></param>
        public void Attack(PlayerCharacter Player)
        {
            Random attackChance = new Random();

            int attackResult = attackChance.Next(0, 2);

            attack = new NormalAttack();


            if (attackResult == 1)
            {
                System.Windows.MessageBox.Show("NPC Attack Successful. Player Turn Now");
                attack.DealDamage(GameController.Enemy.baseDamage, GameController.Player);
                

            }

            if (attackResult == 0)
            {
                System.Windows.MessageBox.Show("NPC Attack UnSuccessful. Player Turn Now ");    


            }


        }

        public NormalAttack NormalAttack
        {
            get
            {
                return attack;
            }
            set
            {
                attack = value;
            }
        }

        public string EnemyType { get => enemyType; set => enemyType = value; }
    }//end NonPlayerCharacter

}