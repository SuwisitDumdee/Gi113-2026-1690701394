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
            // =========================
            // HERO STATS
            // =========================
            int heroHp = 100;
            int heroMana = 50;
            int heroAtk = 30;
            int heroDef = 20;

            // =========================
            // MONSTER STATS
            // =========================
            int monHp = 120;
            int monAtk = 25;

            // =========================
            // POTION STATS
            // =========================
            int potionCount = 3;
            int attackBuff = 20;

            bool parryActive = false;

            // =========================
            // GAME TITLE
            // =========================
            Console.WriteLine("+--------------------------------------+");
            Console.WriteLine("|             JIPPO SLAYER             |");
            Console.WriteLine("+--------------------------------------+");

            // =========================
            // HERO STATUS
            // =========================
            Console.WriteLine("|             HERO STATUS              |");
            Console.WriteLine("+--------------------------------------+");
            Console.WriteLine("|                                      |");
            Console.WriteLine($"|  HP      : {heroHp,-3} / 100                 |");
            Console.WriteLine($"|  MANA    : {heroMana,-3} / 100                 |");
            Console.WriteLine($"|  ATTACK  : {heroAtk,-3}                    |");
            Console.WriteLine($"|  DEFENSE : {heroDef,-3}                    |");
            Console.WriteLine($"|  POTION  : {potionCount,-3}                    |");
            Console.WriteLine("|                                      |");
            Console.WriteLine("+--------------------------------------+");

            // =========================
            // MONSTER STATUS
            // =========================
            Console.WriteLine("|           MONSTER STATUS             |");
            Console.WriteLine("+--------------------------------------+");
            Console.WriteLine("|                                      |");
            Console.WriteLine($"|  HP      : {monHp,-3} / 120                 |");
            Console.WriteLine($"|  ATTACK  : {monAtk,-3}                    |");
            Console.WriteLine("|                                      |");
            Console.WriteLine("+--------------------------------------+");

            // =========================
            // ACTION MENU
            // =========================
            Console.WriteLine("|                ACTION                |");
            Console.WriteLine("+--------------------------------------+");
            Console.WriteLine("|                                      |");
            Console.WriteLine("|  [1] ATTACK                          |");
            Console.WriteLine("|      Attack the monster              |");
            Console.WriteLine("|                                      |");
            Console.WriteLine("|  [2] PARRY                           |");
            Console.WriteLine("|      Block 50% damage                |");
            Console.WriteLine("|                                      |");
            Console.WriteLine("|  [3] DRINK POTION BUFF               |");
            Console.WriteLine("|      Increase Attack by 20           |");
            Console.WriteLine("|                                      |");
            Console.WriteLine("+--------------------------------------+");

            // =========================
            // PLAYER INPUT
            // =========================
            Console.WriteLine();
            Console.Write(">>> CHOOSE YOUR ACTION (1-3): ");

            bool isInputValid =
                int.TryParse(Console.ReadLine(), out int choice);

            // =========================
            // INVALID INPUT
            // =========================
            if (isInputValid == false || choice < 1 || choice > 3)
            {
                Console.WriteLine();
                Console.WriteLine("+--------------------------------------+");
                Console.WriteLine("|             INVALID INPUT            |");
                Console.WriteLine("+--------------------------------------+");
                Console.WriteLine("| Please enter a number between 1-3.  |");
                Console.WriteLine("+--------------------------------------+");
            }

            // =========================
            // ACTION 1 : ATTACK
            // =========================
            else if (choice == 1)
            {
                monHp -= heroAtk;

                Console.WriteLine();
                Console.WriteLine("+--------------------------------------+");
                Console.WriteLine("|                ATTACK                |");
                Console.WriteLine("+--------------------------------------+");
                Console.WriteLine("|                                      |");
                Console.WriteLine(
                    $"| Hero dealt {heroAtk} damage!           |"
                );

                if (monHp <= 0)
                {
                    Console.WriteLine("| Monster is defeated!                |");
                }
                else
                {
                    Console.WriteLine(
                        $"| Monster HP: {monHp} / 120              |"
                    );
                }

                Console.WriteLine("|                                      |");
                Console.WriteLine("+--------------------------------------+");
            }

            // =========================
            // ACTION 2 : PARRY
            // =========================
            else if (choice == 2)
            {
                parryActive = true;

                int damageTaken = monAtk;

                if (parryActive == true)
                {
                    damageTaken = monAtk / 2;
                }

                heroHp -= damageTaken;

                Console.WriteLine();
                Console.WriteLine("+--------------------------------------+");
                Console.WriteLine("|                PARRY                 |");
                Console.WriteLine("+--------------------------------------+");
                Console.WriteLine("|                                      |");
                Console.WriteLine("| Hero prepared to parry!              |");
                Console.WriteLine("| Damage reduced by 50%.               |");
                Console.WriteLine(
                    $"| Monster Attack : {monAtk,-2}                  |"
                );
                Console.WriteLine(
                    $"| Damage Taken   : {damageTaken,-2}                  |"
                );
                Console.WriteLine(
                    $"| Hero HP        : {heroHp,-3} / 100            |"
                );
                Console.WriteLine("|                                      |");
                Console.WriteLine("+--------------------------------------+");
            }

            // =========================
            // ACTION 3 : POTION BUFF
            // =========================
            else if (choice == 3)
            {
                if (potionCount > 0)
                {
                    potionCount--;
                    heroAtk += attackBuff;

                    Console.WriteLine();
                    Console.WriteLine("+--------------------------------------+");
                    Console.WriteLine("|           POTION BUFF                |");
                    Console.WriteLine("+--------------------------------------+");
                    Console.WriteLine("|                                      |");
                    Console.WriteLine("| JIPPO drank a potion!                |");
                    Console.WriteLine(
                        $"| Attack +{attackBuff}                         |"
                    );
                    Console.WriteLine(
                        $"| Hero Attack : {heroAtk,-3}                  |"
                    );
                    Console.WriteLine(
                        $"| Potions Left : {potionCount,-2}                  |"
                    );
                    Console.WriteLine("|                                      |");
                    Console.WriteLine("+--------------------------------------+");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("+--------------------------------------+");
                    Console.WriteLine("|           NO POTIONS LEFT            |");
                    Console.WriteLine("+--------------------------------------+");
                }
            }
        }
    }
}