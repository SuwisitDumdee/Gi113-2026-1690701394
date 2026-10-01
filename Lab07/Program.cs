/*
* Student ID : 1690701394
* Name       : Suwisit Dumdee
* Section    : 129B
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/
using System.Data;

namespace Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MonsterHp = 10;

            Console.WriteLine();
            Console.WriteLine("======================================");
            Console.WriteLine("      ==>>> DRAGON SLAYER <<<==");
            Console.WriteLine("======================================");
            Console.WriteLine();

            Console.Write("Monster Defense: ");
            int.TryParse(Console.ReadLine(), out int monsterDefense);

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"A Slime appears! HP {MonsterHp}, DEF {monsterDefense}");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine();
            Console.WriteLine("=========== BATTLE MENU =============");
            Console.WriteLine("1) Attack");
            Console.WriteLine("2) Fire Magic");
            Console.WriteLine("3) Defend");
            Console.WriteLine("4) Run");
            Console.WriteLine("5) Ice Spear");
            Console.WriteLine("======================================");

            Console.Write("Choose (1-5): ");
            int.TryParse(Console.ReadLine(), out int command);

            Console.WriteLine();

            switch (command)
            {
                case 1:
                    Console.WriteLine("Hero swings the sword!");
                    break;

                case 2:
                    Console.WriteLine("Hero casts Fire!");
                    break;

                case 3:
                    Console.WriteLine("Hero raises the shield.");
                    break;

                case 4:
                    Console.WriteLine("Hero looks for a way out...");
                    break;

                case 5:
                    Console.WriteLine("Hero summons an Ice Spear!");
                    break;

                default:
                    Console.WriteLine("Hero hesitates. Invalid command!");
                    break;
            }

            int power = command switch
            {
                1 => 12,
                2 => 18,
                5 => 15,
                _ => 0
            };

            int damage = Math.Max(0, power - monsterDefense);

            Console.WriteLine($"Damage: {damage}");

            string rating = damage switch
            {
                >= 12 => "Critical hit!",
                >= 5 => "Solid hit.",
                > 0 => "Scratch.",
                _ => "No damage."
            };

            Console.WriteLine($"Rating: {rating}");

            string monsterStatus = damage >= MonsterHp
                ? "DEFEATED"
                : "still standing";

            Console.WriteLine($"Slime: {monsterStatus}");

            Console.WriteLine();
            Console.Write("Really run away? (Y/N): ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "y":
                case "Y":
                    Console.WriteLine("You escaped!");
                    break;

                case "n":
                case "N":
                    Console.WriteLine("You stay and fight.");
                    break;

                default:
                    Console.WriteLine("Please type Y or N.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("======================================");
            Console.WriteLine("       BATTLE SESSION COMPLETE");
            Console.WriteLine("======================================");
        }
    }
}
