using System;
using System.Diagnostics;

namespace UnitTest
{
    internal class Program
    {
        static int health;

        static void Main()
        {
            //Unit Test
            //Debug.Assert(health == 0); 
            UnitTest();

            health = 100;
            //Console.WriteLine("Hello world.");

            //ShowHUD();
            //TakeDamage(150);
            //ShowHUD();
            //Heal(10);
            //ShowHUD();
        }

        static void ShowHUD()
        {
            Console.WriteLine("Health : " + health);
        }

        static void Heal(int hp)
        {
            health += hp;
        }

        static void TakeDamage(int dmg)
        {
            health -= dmg;
        }

        static void UnitTest()
        {
            //unit test
            //set health
            //set bool
            //execute method 
            //assert health
            //assert bool

            //does take damage go bellow 0
            health = 50;
            TakeDamage(60);
            Debug.Assert(health == 100);

        }
    }
}
