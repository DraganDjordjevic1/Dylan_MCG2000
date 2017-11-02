using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class;

namespace Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void ChoosePlayerClass()
        {
            GameController vTest = new GameController(PlayerCharacter, NonPlayerCharacter);
            string vPlayerClass = vTest.ChoosePlayerClass("Thief");
            vPlayerClass = "Warrior";
           
        }
        [TestMethod]
        public void startBattle()
        {
            GameController vTest = new GameController(PlayerCharacter, NonPlayerCharacter);
            vTest.startBattle();
            vTest.startBattle();

        }
        [TestMethod]
        public void normalAttack()
        {
            GameController vTest = new GameController(PlayerCharacter, NonPlayerCharacter);
            vTest.normalAttack();
            vTest.normalAttack();

        }
        [TestMethod]
        public void specialAttack()
        {
            GameController vTest = new GameController(PlayerCharacter, NonPlayerCharacter);
            vTest.specialAttack();
            Assert.AreEqual(vTest.specialAttack());

        }
        [TestMethod]
        public void getNormalAttackDamage()
        {
            PlayerCharacter vTest = new PlayerCharacter(10);
            int vResult = vTest.getNormalAttackDamage(10);
            vResult = 10;

        }
        [TestMethod]
        public void calcSpecialAttack()
        {
            PlayerCharacter vTest = new PlayerCharacter("Player", specialAttack);
            bool vResult = vTest.calcSpecialAttack(true);
            vResult = 10;

        }
        [TestMethod]
        public void getSpecialAttackDamage()
        {
            PlayerCharacter vTest = new PlayerCharacter(20, Warrior);
            int vResult = vTest.getSpecialAttackDamage(20);
            vResult = 20;

        }
        [TestMethod]
        public void specialAttackFailure()
        {
            PlayerCharacter vTest = new PlayerCharacter("Missed Turn");
            vTest.specialAttackFailure();
            vTest.specialAttackFailure();

        }
        [TestMethod]
        public void damageSelf()
        {
            PlayerCharacter vTest = new PlayerCharacter(10);
            int vResult = vTest.damageSelf(10); 
            vResult = 10;

        }
        [TestMethod]
        public void takeDamage()
        {
            NonPlayerCharacter vTest = new NonPlayerCharacter(10, 20);
            int vResult = vTest.takeDamage(10, 20);
            vResult = 10;

        }


    }
}
