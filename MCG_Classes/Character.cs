///////////////////////////////////////////////////////////
//  Character.cs
//  Implementation of the Class Character
//  Generated by Enterprise Architect
//  Created on:      20-Oct-2017 8:38:13 AM
//  Original author: Dylan
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace Class {
	public abstract class Character {

		private int baseDamage;
		private int currentHealthPoints;
		private int maxHealthPoints;

		public Character(int bd, int chp, int mhp)
        {

            baseDamage = bd;
            currentHealthPoints = chp;
            maxHealthPoints = mhp;

        }


    }

	}//end Character

}//end namespace Class