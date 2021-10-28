using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Health_System_v1._0
{
    class Program
    {
        static int health = 100;
        static int shield = 100;
        static int lives = 3;
        static int damage;
        static string healthStatus;
        static int spillover;
        static int exp = 0;
        static int level = 1;
        static int score;
        static int hp;


        static void Main(string[] args)
        {   //Simulated

            UnitTest();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Health System");
            Console.WriteLine("By Brianna Chisholm");
            Console.WriteLine("///////////////////////");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey(true);

            Console.WriteLine();
            ShowHUD();
            Console.ReadKey(true);

            Console.WriteLine();
            damage = 40;
            TakeDamage(damage);
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);


            Reset();
            Console.WriteLine();
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine();
            damage = 125;
            TakeDamage(damage);
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);


            Reset();
            Console.WriteLine();
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine();
            damage = 250;
            TakeDamage(damage);
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);


            Reset();
            Console.WriteLine();
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine();
            damage = -10;
            TakeDamage(damage);
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);


            Reset();
            Console.WriteLine();
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine();
            hp = 100;
            Heal(hp);
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);


            Reset();
            Console.WriteLine();
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine();
            damage = 150;
            TakeDamage(damage);
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine();
            hp = 100;
            Heal(hp);
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);


            Reset();
            Console.WriteLine();
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine();
            hp = -100;
            Heal(hp);
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);


            Reset();
            Console.WriteLine();
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine();
            hp = 100;
            RegenerateShield(hp);
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);


            Reset();
            Console.WriteLine();
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine();
            damage = 50;
            TakeDamage(damage);
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine();
            hp = 100;
            RegenerateShield(hp);
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);


            Reset();
            Console.WriteLine();
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine();
            hp = -100;
            RegenerateShield(hp);
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);


            Reset();
            Console.WriteLine();
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine();
            score = 10;
            Experience(score);
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);


            Reset();
            Console.WriteLine();
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine();
            score = 100;
            Experience(score);
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);


            Reset();
            Console.WriteLine();
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine();
            score = -10;
            Experience(score);
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);


            Reset();
            Console.WriteLine();
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Lives have been reduced to 1 for demonstrations");
            Console.ForegroundColor = ConsoleColor.Gray;
            lives = lives - 2;
            Console.WriteLine();
            damage = 220;
            TakeDamage(damage);
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine();
            damage = 100;
            TakeDamage(damage);
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine("END");
            Console.ReadKey(true);



        }
        //Player Statistics/ Hud Method
        static void ShowHUD()
        {
            if (shield < 0)
            {
                shield = 0;
            }
            if (shield > 100)
            {
                shield = 100;
            }
            if (health < 0)
            {
                health = 0;
            }
            if (health > 100)
            {
                health = 100;
            }
            if (lives < 0)
            {
                lives = 0;
            }
            if (lives > 99)
            {
                lives = 99;
            }


            if (health == 100)
            {
                healthStatus = "Perfect Health";
            }
            else if (health >= 75)
            {
                healthStatus = "Healthy";
            }
            else if (health > 50)
            {
                healthStatus = "Hurt";
            }
            else if (health >= 11)
            {
                healthStatus = "Badly Hurt";
            }
            else if (health == 0)
            {
                healthStatus = "Dead";

            }
            else if (health <= 10)
            {
                healthStatus = "Imminent Danger";
            }


            Console.WriteLine("/////////////////////////////////");
            Console.WriteLine("Level: " + level);
            Console.WriteLine("Player Exp: " + exp);
            Console.WriteLine("Health: " + health + "%");
            Console.WriteLine("Health Status: " + healthStatus);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("/////////////////////////////////");
            Console.WriteLine();



        }
        //Exp and Leveling Method
        static void Experience(int score)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Player is adding " + score + " to their Exp!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey(true);
            Console.WriteLine();

            if (score < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Cannot add negative Exp, must be a positive number");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                score = 0;
            }
            exp = exp + score;



            if (exp == 100)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Player has earned a Level Up!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                level = level + 1;
            }
        }
        //Code Impacting Health, Shield and Lives
        static void TakeDamage(int damage)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Player is about to take " + damage + " hit points of damage...");
            Console.ReadKey(true);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            if (damage < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Cannot take Damage of a negative value, must be a positive value");
                Console.ForegroundColor = ConsoleColor.Gray;
                damage = 0;
            }
            if (damage > shield)
            {
                spillover = damage - shield;
                health = health - spillover;
                shield = shield - damage;
            }
            if (health <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Player lost a life.");
                Console.ForegroundColor = ConsoleColor.Gray;
                lives = lives - 1;

                if (lives == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Out of Lives.");
                    Console.ForegroundColor = ConsoleColor.Gray;


                }

                else if (lives > 0)
                {
                    health = 100;
                    shield = 100;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Player used a 1UP and restored their Health and Shield!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                }

            }

            else if (shield > 0)
            {
                shield = shield - damage;

            }

            if (lives < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error Message: Cannot lose more lives than 0...");
                Console.ForegroundColor = ConsoleColor.Gray;
                lives = 0;
                health = 0;
                shield = 0;

            }

            if (shield < 0)
            {
                shield = 0;
            }

            if (health < 0)
            {
                health = 0;
            }

            if (lives < 0)
            {
                lives = 0;
            }
            if (lives > 99)
            {
                lives = 99;
            }









        }
        static void Reset()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("DEBUG: RESET");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey(true);
            exp = 0;
            level = 1;
            shield = 100;
            health = 100;
            lives = 3;

        }

        //Health and Shield Regeneration Methods
        static void Heal(int hp)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Player is about to Heal by " + hp + " hit points");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey(true);
            Console.WriteLine();
            if (hp < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Cannot Heal Player by a negative number, must be a positive number");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                hp = 0;
            }
            health = health + hp;
            if (health > 100)
            {
                health = 100;
            }
        }

        static void RegenerateShield(int hp)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Player is about to Regenerate Shield by " + hp + " hit points");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey(true);
            Console.WriteLine();
            if (hp < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Cannot Regenerate Shield by a negative number, must be a positive number");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                hp = 0;
            }
            shield = shield + hp;
            if (shield > 100)
            {
                shield = 100;
            }
        }
        static void UnitTest()
        {
            damage = 40;

            TakeDamage(damage);

            Debug.Assert(shield >= 0);
            Debug.Assert(health == 100);
            Console.WriteLine();

            Console.WriteLine();
            Reset();

            damage = 125;
            TakeDamage(damage);

            Debug.Assert(shield >= 0);
            Debug.Assert(shield <= 100);
            Debug.Assert(health >= 0);
            Debug.Assert(health <= 100);
            Console.WriteLine();

            Console.WriteLine();
            Reset();

            damage = 250;
            TakeDamage(damage);


            Debug.Assert(shield >= 0);
            Debug.Assert(health <= 100);
            Debug.Assert(lives < 3);
            Console.WriteLine("Success");
            Console.WriteLine();
            Reset();

            damage = -10;
            TakeDamage(damage);



            Debug.Assert(shield == 100);
            Debug.Assert(health == 100);
            Console.WriteLine("Success");
            Reset();


            hp = 100;
            Heal(hp);

            Debug.Assert(health == 100);
            Reset();


            damage = 150;
            TakeDamage(damage);
            hp = 100;
            Heal(hp);

            Debug.Assert(health == 100);
            Reset();


            hp = -100;
            Heal(hp);

            Debug.Assert(health == 100);
            Reset();

            hp = 100;
            RegenerateShield(hp);

            Debug.Assert(shield == 100);
            Reset();


            damage = 50;
            TakeDamage(damage);
            hp = 100;
            RegenerateShield(hp);

            Debug.Assert(shield == 100);
            Reset();


            hp = -100;
            RegenerateShield(hp);

            Debug.Assert(shield == 100);
            Reset();

            score = 10;
            Experience(score);
            Debug.Assert(exp > 0);

            Reset();

            score = 100;
            Experience(score);
            Debug.Assert(exp == 100);
            Debug.Assert(level == 2);

            Reset();

            score = -10;
            Experience(score);

            Debug.Assert(exp == 0);

        }
    }
}

