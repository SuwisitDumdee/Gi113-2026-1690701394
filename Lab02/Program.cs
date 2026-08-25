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
            string minibossName = "AUNGPO";
            char rank = 'S';
            int level = 15;
            int maxMana = 500;
            int currentMana = 200;

            Console.WriteLine($"MINIBOSS STATUS: INITIAL");
            Console.WriteLine($"Name: {minibossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Mana: {currentMana} / {maxMana}");
            Console.WriteLine();

            string playerName = "Numpan";
            char rank = 'E';
            int level = 5;
            int maxStamina = 1000;
            int currentStamina = 600;

            Console.WriteLine($"PLAYER STATUS: INITIAL");
            Console.WriteLine($"Name: {playerName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Stamina: {currentStamina} / {maxStamina}");
            Console.WriteLine();

            string playerName = "Kawin";
            char rank = 'C';
            int level = 7;
            double criMultiplier = 0.75;

            Console.WriteLine($"PLAYER STATUS: INITIAL");
            Console.WriteLine($"Name: {playerName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Crit Multiplier: {criMultiplier}");
            Console.WriteLine();

            string npcName = "Jippo";
            char rank = 'A';
            int level = 20;
            int maxHP = 2500;
            float attackSpeed = 125.5f;
            double critMultiplier = 2.35;
            bool isNPC = true;

            Console.WriteLine($"NPC STATUS: INITIAL");
            Console.WriteLine($"Name: {npcName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Max HP: {maxHP}");
            Console.WriteLine($"Attack Speed: {attackSpeed}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is NPC: {isNPC}");
            Console.WriteLine();
        }
    }
}
