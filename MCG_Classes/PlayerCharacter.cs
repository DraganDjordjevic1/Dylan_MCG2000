///////////////////////////////////////////////////////////
//  PlayerCharacter.cs
//  Implementation of the Class PlayerCharacter
//  Generated by Enterprise Architect
//  Created on:      20-Oct-2017 8:38:13 AM
//  Original author: Dylan
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Class;
namespace Class
{
	public class PlayerCharacter : Character
    {

		private char characterName;
        private NormalAttack normalAttack;
		public NormalAttack m_NormalAttack;
		

		public PlayerCharacter(char cname, NormalAttack normAttack, NormalAttack m_normalattack, int bd, int mhp, int chp) : base(bd,mhp,chp)
        {
            characterName = cname;
            normalAttack = normAttack;
            m_NormalAttack = m_normalattack;
            
		}

        public int getNormalAttackDamage(int v)
        {
            throw new NotImplementedException();
        }

        public int getSpecialAttackDamage(int v)
        {
            throw new NotImplementedException();
        }

        public void specialAttackFailure()
        {
            throw new NotImplementedException();
        }

        public bool calcSpecialAttack(bool v)
        {
            throw new NotImplementedException();
        }

        public int damageSelf(int v)
        {
            throw new NotImplementedException();
        }
    }
		public void specialAttack()
        {
        throw new NotImplementedException();
		}

}//end PlayerCharacter
