/*
* Student ID : 1690701394
* Name       : Suwisit Dumdee
* Section    : 129B
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/
namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==> GAME KAWIN WEAKNESS <==");
            Console.WriteLine("HERO vs. MONSTER -- Caluclate Damge");

            //HERO Stats
            Console.Write("HERO HP: ");
            bool heroHpOK = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("HERO ATK: ");
            bool heroAtkOK = int.TryParse(Console.ReadLine(), out int heroATK);
            Console.Write("HERO DEFENSE: ");
            bool heroDefOK = int.TryParse(Console.ReadLine(), out int heroDef);

            //MONSTER Stats
            Console.Write("MONSTER HP: ");
            bool monHpOK = int.TryParse(Console.ReadLine(), out int monHp);
            Console.Write("MONSTER ATK: ");
            bool monAtkOK = int.TryParse(Console.ReadLine(), out int monATK);
            Console.Write("MONSTER DEFENSE: ");
            bool monDefOK = int.TryParse(Console.ReadLine(), out int monDef);

            //Check for valid input
            bool heroInputValid = heroHpOK && heroAtkOK && heroDefOK;
            bool monsterInputValid = monHpOK && monAtkOK && monDefOK;
            Console.WriteLine($"=>> Hero stats valid: {heroInputValid}");
            Console.WriteLine($"=>> Monster stats valid: {monsterInputValid}");
            Console.WriteLine($"[HERO]        HP: {heroHp}, ATK: {heroATK}, DEF: {heroDef}");
            Console.WriteLine($"[MONSteR]     HP: {monHp}, ATK: {monATK}, DEF: {monDef}");

            //HERO DRINKS POTION HEAL BEFORE THE FIGHT
            int potionHeal = 14;
            heroHp += potionHeal; //Hero drinks HP Potion
            Console.WriteLine($"Hero drinks a potion, healing {potionHeal} HP, Hero Hp is: {heroHp}");

            int normalDamge = Math.Max(0, heroATK - monDef); //Normal ATK By -
            Console.WriteLine($"Normal attack deals: {normalDamge} DMG");

            int powerDamage = Math.Max(0, (heroATK * 2) - monDef);//ATK Power By *
            Console.WriteLine($"Power attack deals: {powerDamage} DMG0");

            int counterDamge = Math.Max(0, monATK - heroDef);//Monster counterATK
            Console.WriteLine($"Counter attack deals: {counterDamge} DMG");

            Random randomSomething = new Random();
            int roll = randomSomething.Next(1, 101); //เมื่อสุ่มต้อง +1 เสมอ
            bool isCrit = roll <= 10; //โอกาส 10 ตัว ใน 100 คือ 10%
            int critDamge = normalDamge + Convert.ToInt32(isCrit) * normalDamge;// ได้ค่า 1 หรือ 0 เป็นตัวกำหนดว่าจะติดCritมั้ย?
            Console.WriteLine($"Crit Damage roll: {roll} (Crit: {isCrit})");
            Console.WriteLine($"If critical, normal attack would deal: {critDamge} DMG");
        }
    }
}
