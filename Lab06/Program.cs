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
            int heroHp = 100;
            int monHp = 100;
            int heroAtk = 50;
            int heroMana = 50;
            int manaRestore = 30;
            int monAtk = 50;
            bool shieldActive = false;

            Console.WriteLine("+--------------------------------------+");
            Console.WriteLine("|            JIPPO SLAYER             |");
            Console.WriteLine("+--------------------------------------+");
            Console.WriteLine("|                                      |");
            Console.WriteLine("|  [1] ATTACK                         |");
            Console.WriteLine("|      Attack the monster              |");
            Console.WriteLine("|                                      |");
            Console.WriteLine("|  [2] DEFENSE ATTACK                 |");
            Console.WriteLine("|      Block 50% damage                |");
            Console.WriteLine("|                                      |");
            Console.WriteLine("|  [3] RESTORE MANA                   |");
            Console.WriteLine("|      Recover 30 Mana                 |");
            Console.WriteLine("|                                      |");
            Console.WriteLine("+--------------------------------------+");
            Console.WriteLine("|                                      |");
            Console.WriteLine($"|  HP   : {heroHp,-3} / 100                  |");
            Console.WriteLine($"|  MANA : {heroMana,-3} / 100                  |");
            Console.WriteLine($"|  MONSTER HP : {monHp,-3} / 100             |");
            Console.WriteLine("|                                      |");
            Console.WriteLine("+--------------------------------------+");

            Console.WriteLine();
            Console.Write(">>> CHOOSE YOUR ACTION (1-3): ");

            bool isInputValid = int.TryParse(
                Console.ReadLine(),
                out int choice
            );

            if (isInputValid == false || choice < 1 || choice > 3)
            {
                Console.WriteLine(
                    "Invalid Input, Please enter action between 1 and 3"
                );
            }
            else if (choice == 1)
            {
                monHp -= heroAtk;

                if (monHp <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(
                        $"Hero attacked the monster with {heroAtk} DMG!"
                    );
                    Console.WriteLine("Monster is defeated!");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(
                        $"Hero attacked the monster with {heroAtk} DMG!"
                    );
                    Console.WriteLine(
                        $"Monster now has {monHp} HP left!"
                    );
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Hero raised the shield!");
                Console.WriteLine("Shield will reduce damage by 50%");

                int reducedDamage = monAtk / 2;
                heroHp -= reducedDamage;

                Console.WriteLine("Monster attacked!");
                Console.WriteLine("Shield blocked some damage");
                Console.WriteLine($"Hero took {reducedDamage} DMG");
            }
            else if (choice == 3)
            {
                heroMana += manaRestore;

                Console.WriteLine();
                Console.WriteLine("Hero restored Mana!");
                Console.WriteLine($"Hero recovered {manaRestore} Mana.");
                Console.WriteLine($"Hero Mana is now {heroMana} Points.");
            }


        }
    }
}
