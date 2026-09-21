/*
* Student ID : 1690701394
* Name       : Suwisit Dumdee
* Section    : 129B
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/
namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Ex:
            bool isPoisoned = false;
            if (isPoisoned) { } // ได้เลยเพราะ isPoisoned = false
            if (!isPoisoned) { } // ไม่จริง เพราะ isPoisoned = false

            bool haskey = true;
            Console.Write("Your level (1-99): ");
            bool ok = int.TryParse(Console.ReadLine(), out int level);

            if (!ok || level < 1 || level > 99)
            {
                Console.WriteLine("Invalid Level Input");
            }
            else if (level >= 10 && haskey)
            {
                Console.WriteLine("Boss floor unlocked.");
            }
            else if (level >= 5)
            {
                if (haskey == true)
                {
                    Console.WriteLine("The door opens.");
                }
                else
                { 
                    Console.WriteLine("Locked. Find a key");
                }
            }
            else
            {
                Console.WriteLine("The door stays shut.");
            }
            //End Ex

            int heroHp = 100;
            int monHp = 100;
            int heroAtk = 50;
            int potionHeal = 50;

            Console.WriteLine("HERO BRAIN ENCOUNTER A MONSTER....");
            Console.WriteLine("ACTION 1: ATTACK");
            Console.WriteLine("ACTION 2: DRINK HP POTION");

            Console.Write("CHOOSE YOUR ACTION (1-2): ");
            bool isInputValid = int.TryParse(Console.ReadLine(), out int choice);

            if (isInputValid == false || choice < 1 || choice > 2)
            {
                Console.WriteLine("Invalid Input, Please enter action between 1 and 2");
            }
            else if (choice == 1)
            {
                monHp -= heroAtk;
                if (monHp <= 0)
                {
                    Console.WriteLine($"Hero attacked the monster!!! with {heroAtk} DMG, Monster is defeated!");
                }
                else
                {
                    Console.WriteLine($"Hero attacked the monster!!! with {heroAtk} DMG, Monster now have {monHp} HP left!");
                }
            }
            else if (choice == 2)
            {
                heroHp += potionHeal;
                Console.WriteLine($"Hero drank a potion, Hero HP is now {heroHp} Points");
            }


        }
    }
}
