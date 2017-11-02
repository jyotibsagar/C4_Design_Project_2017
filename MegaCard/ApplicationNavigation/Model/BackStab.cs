
//  Implementation of the Class BackStab
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ApplicationNavigation.Model
{


    public class BackStab : SpecialAttack
    {

        public BackStab()
        {

        }

        ~BackStab()
        {

        }

        /// <summary>
        /// Attacks the NPC and targets the health points. Function will return 0
        /// </summary>
        /// <param name="NPC"></param>
        public int MakeAttack(NonPlayerCharacter NPC)
        {

            return 0;
        }

    }//end BackStab

}