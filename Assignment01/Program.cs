/*
* Student ID : 1690701394
* Name       : Suwisit Dumdee
* Section    : 129B
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/
namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "BLACK MYTH: WUKONG";

            var characterName = "The Destined One";
            var characterRank = 'S';

            int characterLevel = 68;
            int defense = 142;
            int mana = 350;
            int stamina = 480;
            float attackPower = 185.5f;
            double healthPoint = 920.5;
            bool hasGourd = true;

            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine($"║        {GameTitle}         ║");
            Console.WriteLine("╠════════════════════════════════════╣");
            Console.WriteLine($"║ Character : {characterName}");
            Console.WriteLine($"║ Rank      : {characterRank}");
            Console.WriteLine($"║ Level     : {characterLevel}");
            Console.WriteLine("╠════════════════════════════════════╣");
            Console.WriteLine($"║ HP        : {healthPoint}");
            Console.WriteLine($"║ Mana      : {mana}");
            Console.WriteLine($"║ Stamina   : {stamina}");
            Console.WriteLine($"║ Attack    : {attackPower}");
            Console.WriteLine($"║ DEF       : {defense}");
            Console.WriteLine($"║ Gourd     : {hasGourd}");
            Console.WriteLine("╚════════════════════════════════════╝");

            Console.WriteLine();
            Console.WriteLine("----- Implicit Conversion -----");

            double levelAsDouble = characterLevel;

            Console.WriteLine($"Level as double : {levelAsDouble}");

            Console.WriteLine();
            Console.WriteLine("----- Cast vs Convert -----");

            int attackCast = (int)attackPower;
            int attackConvert = Convert.ToInt32(attackPower);

            Console.WriteLine($"Attack with cast    : {attackCast}");
            Console.WriteLine($"Attack with Convert : {attackConvert}");
        }
    }
}
