/*
 * Student ID : 1690701394
 * Name       : Suwisit Dumdee
 * Section    : 129B
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part A
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("BOSS STATUS: INITIAL");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();

            int hpPercent = currentHp * 10 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();

            Console.WriteLine($"Kirin takes 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();

            Console.WriteLine($"BOSS STATUS: AFTER DAMAGE");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");

            // Part B
            string playerName1 = "Aungpao";
            char rank1 = 'S';
            int level1 = 7;
            int maxHp1 = 240;
            int currentHp1 = 175;
            float attackPower1 = 42.5f;
            double critMultiplier1 = 1.75;
            bool isBoss1 = true;

            Console.WriteLine("===== CHARACTER 1 =====");
            Console.WriteLine($"NAME: {playerName1}");
            Console.WriteLine($"RANK: {rank1}");
            Console.WriteLine($"LEVEL: {level1}");
            Console.WriteLine($"HP: {currentHp1} / {maxHp1}");
            Console.WriteLine($"ATTACK POWER: {attackPower1}");
            Console.WriteLine($"CRIT MULTIPLIER: {critMultiplier1}");
            Console.WriteLine($"IS BOSS: {isBoss1}");
            Console.WriteLine();

            string playerName2 = "Kawin";
            char rank2 = 'A';
            int level2 = 15;
            int maxStamina2 = 1000;
            int currentStamina2 = 1000;
            float attackPower2 = 68.5f;
            double critMultiplier2 = 2.10;
            bool isBoss2 = false;

            Console.WriteLine("===== CHARACTER 2 =====");
            Console.WriteLine($"NAME: {playerName2}");
            Console.WriteLine($"RANK: {rank2}");
            Console.WriteLine($"LEVEL: {level2}");
            Console.WriteLine($"STAMINA: {currentStamina2} / {maxStamina2}");
            Console.WriteLine($"ATTACK POWER: {attackPower2}");
            Console.WriteLine($"CRIT MULTIPLIER: {critMultiplier2}");
            Console.WriteLine($"IS BOSS: {isBoss2}");
            Console.WriteLine();

            string playerName3 = "Numpan";
            char rank3 = 'B';
            int level3 = 12;
            int maxMana3 = 750;
            int currentMana3 = 750;
            float attackPower3 = 75.5f;
            double critMultiplier3 = 1.95;
            bool isBoss3 = false;

            Console.WriteLine("===== CHARACTER 3 =====");
            Console.WriteLine($"NAME: {playerName3}");
            Console.WriteLine($"RANK: {rank3}");
            Console.WriteLine($"LEVEL: {level3}");
            Console.WriteLine($"MANA: {currentMana3} / {maxMana3}");
            Console.WriteLine($"ATTACK POWER: {attackPower3}");
            Console.WriteLine($"CRIT MULTIPLIER: {critMultiplier3}");
            Console.WriteLine($"IS BOSS: {isBoss3}");
            Console.WriteLine();

            string playerName4 = "Tae";
            char rank4 = 'S';
            int level4 = 30;
            int maxDefense4 = 470;
            int currentDefense4 = 470;
            float attackPower4 = 120.5f;
            double critMultiplier4 = 2.50;
            bool isBoss4 = true;

            Console.WriteLine("===== CHARACTER 4 =====");
            Console.WriteLine($"NAME: {playerName4}");
            Console.WriteLine($"RANK: {rank4}");
            Console.WriteLine($"LEVEL: {level4}");
            Console.WriteLine($"DEFENSE: {currentDefense4} / {maxDefense4}");
            Console.WriteLine($"ATTACK POWER: {attackPower4}");
            Console.WriteLine($"CRIT MULTIPLIER: {critMultiplier4}");
            Console.WriteLine($"IS BOSS: {isBoss4}");
            Console.WriteLine();
        }
    }
}