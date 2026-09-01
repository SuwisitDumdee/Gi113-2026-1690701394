/*
* Student ID : 1690701394
* Name       : Suwisit Dumdee
* Section    : 129B
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/
namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Maxlevel = 10;

            var bossName = "Kirin";
            var rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;
            float attackpower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            // Boss Stats Console.WriteLine("===KIRIN SAVE CONVERTER===");
            Console.WriteLine($"NAME: {bossName}" +
                $"\nRank: {rank}" +
                $"\nLEVEL: {level} / {Maxlevel}" +
                $"\nHP: {currentHp} / {maxHp}" +
                $"\nATTACK POWER: {attackpower}" +
                $"\nCRIT MULTIPLIER: {critMultiplier}" +
                $"\nIS BOSS: {isBoss}");

            // Implicit conversion HP (int) -->> doubleConsole.WriteLine("\n----- Implicit Conversion: HP as double -----");
            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp;
            Console.WriteLine($"Hp (double):{currentHpDouble}");

            // Calcuate Percent as doubleConsole.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
            Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
            double hppercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"Hp Percent (exact): {hppercentExact}%");

            // Explicit casting attack power (float) -->> int// Cast vs. Convert: Crit Multiplier
            Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display Int -----");
            int attackDisplay = (int)attackpower;
            Console.WriteLine($"Attack Power (int cast): {attackDisplay}");

            // Cast vs. Convert: Crit Multiplier
            Console.WriteLine("\n----- Cast vs Convert: Crit Multiplier -----");
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Crit Multiplier (int cast): {critCast}");
            Console.WriteLine($"Crit Multiplier (Convert rounded): {critConvert}");
        }
    }
}