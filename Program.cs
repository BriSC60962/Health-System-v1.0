using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        {
            Console.WriteLine("Health System");
            Console.WriteLine("By Brianna Chisholm");
            Console.WriteLine("///////////////////////");
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

            Console.WriteLine("Resetting...");
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

            Console.WriteLine("Resetting...");
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

            Console.WriteLine("Resetting...");
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

            Console.WriteLine("Resetting...");
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

            Console.WriteLine("Resetting...");
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

            Console.WriteLine("Resetting...");
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

            Console.WriteLine("Resetting...");
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

            Console.WriteLine("Resetting...");
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

            Console.WriteLine("Resetting...");
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

            Console.WriteLine("Resetting...");
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

            Console.WriteLine("Resetting...");
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

            Console.WriteLine("Resetting...");
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

            Console.WriteLine("Resetting...");
            Reset();
            Console.WriteLine();
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);

            lives = lives - 2;
            Console.WriteLine();
            damage = 220;
            TakeDamage(damage);
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);

         


        }
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
        static void Experience(int score)
        {
            Console.WriteLine("DEBUG: Player is adding " + score + " to their Exp!");
            Console.WriteLine();

            if (score < 0)
            {
                Console.WriteLine("ERROR: Cannot add negative Exp, must be a positive number");
                Console.WriteLine();
                score = 0;
            }
            exp = exp + score;
            
           

            if (exp == 100)
            {
                Console.WriteLine("DEBUG: Player has earned a Level Up!");
                Console.WriteLine();
                level = level + 1;
            }
        }

        static void TakeDamage(int damage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("DEBUG: Player is about to take " + damage + " hit points of damage...");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            if(damage < 0)
            {
                Console.WriteLine("ERROR: Cannot take Damage of a negative value, must be a positive value");
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
                Console.WriteLine("Player lost a life.");
                if (lives < 0)
                {
                    health = 100;
                    shield = 100;
                    Console.WriteLine("Player used a 1UP and restored their Health and Shield!");
                    Console.WriteLine();
                }
                
                lives = lives - 1;
                
            }

            else if (shield > 0)
            {
                shield = shield - damage;

            }







            if (lives == 0)
            {
                Console.WriteLine("Out of Lives! The Game is Over!!!");
                health = 0;
                shield = 0;

            }
            else if (lives < 0)
            {
                Console.WriteLine("Error Message: Cannot lose more lives than 0...");
                lives = 0;
                health = 0;
                shield = 0;

            }











        }
        static void Reset()
        {
            exp = 0;
            level = 1;
            shield = 100;
            health = 100;
            lives = 3;

        }

        static void Heal(int hp)
        {
            Console.WriteLine("DEBUG: Player is about to Heal by " + hp + " hit points");
            Console.WriteLine();
            if (hp < 0)
            {
                Console.WriteLine("ERROR: Cannot Heal Player by a negative number, must be a positive number");
                Console.WriteLine();
                hp = 0;
            }
            health = health + hp;
        }

        static void RegenerateShield(int hp)
        {
            Console.WriteLine("DEBUG: Player is about to Regenerate Shield by " + hp + " hit points");
            Console.WriteLine();
            if (hp < 0)
            {
                Console.WriteLine("ERROR: Cannot Regenerate Shield by a negative number, must be a positive number");
                Console.WriteLine();
                hp = 0;
            }
            shield = shield + hp;
        }
    }
}
