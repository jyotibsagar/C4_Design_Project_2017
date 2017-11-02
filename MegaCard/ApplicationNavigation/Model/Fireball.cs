///////////////////////////////////////////////////////////
//  Fireball.cs
//  Implementation of the Class Fireball
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ApplicationNavigation.Model
{


    public class Fireball : SpecialAttack
    {

        public Fireball()
        {

        }

        ~Fireball()
        {

        }

        /// <summary>
        /// Attacks the NPC and targets the health points. If attack is successful the
        /// function will return 0. If unsuccessful, will return base damage.
        /// </summary>
        /// <param name="NPC"></param>
        public int MakeAttack(NonPlayerCharacter NPC)
        {

            return 0;
        }

    }//end Fireball

}