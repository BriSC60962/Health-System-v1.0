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

        static void Main(string[] args)
        {
            Console.WriteLine("Health System");
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);
            damage = 101;
            TakeDamage(damage);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine();
            damage = 100;
            TakeDamage(damage);
            ShowHUD();
            TakeDamage(damage);
            ShowHUD();
            TakeDamage(damage);
            ShowHUD();
            TakeDamage(damage);
            ShowHUD();
            TakeDamage(damage);
            ShowHUD(); 
            TakeDamage(damage);
            ShowHUD();
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





            Console.WriteLine("Health: " + health + "%");
            Console.WriteLine("Health Status: " + healthStatus);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine();



        }


        static void TakeDamage(int damage)
        {
          
             if (shield > 0)
            {
                shield = shield - damage;
                
            }
            else if (damage > shield)
                {
                    spillover = damage - shield;
                    health = health - spillover;
                    if (health == 0)
                    {
                        lives = lives - 1;
                        health = health + 100;
                        shield = shield + 100;
                    }
                }
                else if (shield <= 0)
                {

                health = health - damage;

                if (health <= 0)
                {
                    lives = lives - 1;
                    health = health + 100;
                    
                }
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

            }











        }

        static void Heal(int hp)
        {
           

            health = health + hp;
        }

        static void RegenerateShield(int hp)
        {
            

            shield = shield + hp;
        }
    }
}
