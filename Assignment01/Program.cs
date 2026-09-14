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
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            const string GameTitle = @"
 ██████╗ ██╗      █████╗  ██████╗██╗  ██╗
 ██╔══██╗██║     ██╔══██╗██╔════╝██║ ██╔╝
 ██████╔╝██║     ███████║██║     █████╔╝
 ██╔══██╗██║     ██╔══██║██║     ██╔██╗
 ██████╔╝███████╗██║  ██║╚██████╗██╔╝ ██╗
 ╚═════╝ ╚══════╝╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝

 ███╗   ███╗██╗   ██╗████████╗██╗  ██╗
 ████╗ ████║╚██╗ ██╔╝╚══██╔══╝██║  ██║
 ██╔████╔██║ ╚████╔╝    ██║   ███████║
 ██║╚██╔╝██║  ╚██╔╝     ██║   ██╔══██║
 ██║ ╚═╝ ██║   ██║      ██║   ██║  ██║
 ╚═╝     ╚═╝   ╚═╝      ╚═╝   ╚═╝  ╚═╝

 ██╗    ██╗██╗   ██╗██╗  ██╗ ██████╗ ███╗   ██╗ ██████╗
 ██║    ██║██║   ██║██║ ██╔╝██╔═══██╗████╗  ██║██╔════╝
 ██║ █╗ ██║██║   ██║█████╔╝ ██║   ██║██╔██╗ ██║██║  ███╗
 ██║███╗██║██║   ██║██╔═██╗ ██║   ██║██║╚██╗██║██║   ██║
 ╚███╔███╔╝╚██████╔╝██║  ██╗╚██████╔╝██║ ╚████║╚██████╔╝
  ╚══╝╚══╝  ╚═════╝ ╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═══╝ ╚═════╝
";

            var characterName = "The Destined One";
            var characterRank = 'S';

            int characterLevel = 256;
            int defenseRating = 304;
            int manaPool = 500;
            int staminaPool = 700;
            float attackDamage = 245.5f;
            double healthPoint = 920.5;
            bool hasHealingGourd = true;

            Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine(GameTitle);
            Console.WriteLine("╠════════════════════════════════════════════════════════════╣");
            Console.WriteLine($"║ Character : {characterName}");
            Console.WriteLine($"║ Rank      : {characterRank}");
            Console.WriteLine($"║ Level     : {characterLevel}");
            Console.WriteLine("╠════════════════════════════════════════════════════════════╣");
            Console.WriteLine($"║ HP        : {healthPoint}");
            Console.WriteLine($"║ Mana      : {manaPool}");
            Console.WriteLine($"║ Stamina   : {staminaPool}");
            Console.WriteLine($"║ Attack    : {attackDamage}");
            Console.WriteLine($"║ DEF       : {defenseRating}");
            Console.WriteLine($"║ Gourd     : {hasHealingGourd}");
            Console.WriteLine("╚════════════════════════════════════════════════════════════╝");

            Console.WriteLine();
            Console.WriteLine("----- Implicit Conversion -----");

            double levelAsDouble = characterLevel;

            Console.WriteLine($"Level as double : {levelAsDouble}");

            Console.WriteLine();
            Console.WriteLine("----- Cast vs Convert -----");

            int attackCast = (int)attackDamage;
            int attackConvert = Convert.ToInt32(attackDamage);

            Console.WriteLine($"Attack with cast    : {attackCast}");
            Console.WriteLine($"Attack with Convert : {attackConvert}");
            Console.WriteLine();
        }
    }
}
