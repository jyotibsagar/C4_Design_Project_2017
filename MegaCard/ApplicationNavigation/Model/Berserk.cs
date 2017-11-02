///////////////////////////////////////////////////////////
//  Berserk.cs
//  Implementation of the Class Berserk
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ApplicationNavigation.Model
{


    public class Berserk : SpecialAttack
    {

        public Berserk()
        {

        }

        ~Berserk()
        {

        }

        /// <summary>
        /// Attacks the NPC and targets the health points. Function will return 0.
        /// </summary>
        /// <param name="NPC"></param>
        public int MakeAttack(NonPlayerCharacter NPC)
        {

            return 0;
        }

    }//end Berserk

}