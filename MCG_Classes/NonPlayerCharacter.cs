///////////////////////////////////////////////////////////
//  NonPlayerCharacter.cs
//  Implementation of the Class NonPlayerCharacter
//  Generated by Enterprise Architect
//  Created on:      20-Oct-2017 8:38:13 AM
//  Original author: Dylan
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Class;
namespace Class {
	public class NonPlayerCharacter : Character {

		private NormalAttack attack;
		/// <summary>
		/// e.g. goblin, giant etc
		/// </summary>
		private char enemyType;
		public Class.NormalAttack m_NormalAttack;

		public NonPlayerCharacter()
        {
            throw new NotImplementedException();
        }

		~NonPlayerCharacter(){

		}

        public int takeDamage()
        {
            throw new NotImplementedException();
        }

        public int takeDamage(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }//end NonPlayerCharacter

}//end namespace Class