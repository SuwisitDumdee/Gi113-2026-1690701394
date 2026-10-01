/*
* Student ID : 1690701394
* Name       : Suwisit Dumdee
* Section    : 129B
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/
namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MaterialName = "Iron";
            const double SmeltRate = 0.25;
            const double SalvageRate = 0.30;
            const double MaxBatch = 500.0;

            Console.WriteLine();
            Console.WriteLine("╔══════════════════════════════════════════════╗");
            Console.WriteLine("║                 DRAGONFORGE                  ║");
            Console.WriteLine("║           THE ANCIENT IRON WORKS             ║");
            Console.WriteLine("╠══════════════════════════════════════════════╣");
            Console.WriteLine($"║  Material       : {MaterialName,-26} ║");
            Console.WriteLine($"║  Smelt Rate     : {SmeltRate,-26:F4} ║");
            Console.WriteLine($"║  Salvage Rate   : {SalvageRate,-26:F4} ║");
            Console.WriteLine($"║  Max Batch      : {MaxBatch,-26:F2} ║");
            Console.WriteLine("╚══════════════════════════════════════════════╝");

            Console.WriteLine();
            Console.WriteLine("┌──────────────────────────────────────────────┐");
            Console.WriteLine("│                  FORGE MENU                  │");
            Console.WriteLine("├──────────────────────────────────────────────┤");
            Console.WriteLine("│                                              │");
            Console.WriteLine("│   [ S ]  SMELT                               │");
            Console.WriteLine("│          Ore  ======>  Ingot                 │");
            Console.WriteLine("│                                              │");
            Console.WriteLine("│   [ B ]  BREAKDOWN                           │");
            Console.WriteLine("│          Ingot ======> Ore                   │");
            Console.WriteLine("│                                              │");
            Console.WriteLine("└──────────────────────────────────────────────┘");

            Console.WriteLine();

            Console.Write("Choose Menu [S/B] : ");
            string menuInput = Console.ReadLine();

            Console.Write("Enter Amount       : ");
            string amountInput = Console.ReadLine();

            char menu;
            double amount;

            bool menuValid = char.TryParse(menuInput, out menu);
            bool amountValid = double.TryParse(amountInput, out amount);

            if (amountValid && amount > 0 && amount <= MaxBatch)
            {
                if ((menu == 'S') || (menu == 's'))
                {
                    double ingot = amount * SmeltRate;

                    Console.WriteLine();
                    Console.WriteLine("╔══════════════════════════════════════════════╗");
                    Console.WriteLine("║                 SMELTING COMPLETE            ║");
                    Console.WriteLine("╠══════════════════════════════════════════════╣");
                    Console.WriteLine($"║  Input  : {amount:F2} {MaterialName} Ore");
                    Console.WriteLine($"║  Rate   : {SmeltRate:F4}");
                    Console.WriteLine($"║  Output : {ingot:F2} {MaterialName} Ingot");
                    Console.WriteLine("╠══════════════════════════════════════════════╣");
                    Console.WriteLine($"║  => {amount:F2} {MaterialName} Ore");
                    Console.WriteLine($"║     = {ingot:F2} {MaterialName} Ingot");
                    Console.WriteLine("╚══════════════════════════════════════════════╝");
                }
                else if ((menu == 'B') || (menu == 'b'))
                {
                    double ore = amount / SalvageRate;

                    Console.WriteLine();
                    Console.WriteLine("╔══════════════════════════════════════════════╗");
                    Console.WriteLine("║               BREAKDOWN COMPLETE             ║");
                    Console.WriteLine("╠══════════════════════════════════════════════╣");
                    Console.WriteLine($"║  Input  : {amount:F2} {MaterialName} Ingot");
                    Console.WriteLine($"║  Rate   : {SalvageRate:F4}");
                    Console.WriteLine($"║  Output : {ore:F2} {MaterialName} Ore");
                    Console.WriteLine("╠══════════════════════════════════════════════╣");
                    Console.WriteLine($"║  => {amount:F2} {MaterialName} Ingot");
                    Console.WriteLine($"║     = {ore:F2} {MaterialName} Ore");
                    Console.WriteLine("╚══════════════════════════════════════════════╝");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("╔══════════════════════════════════════════════╗");
                    Console.WriteLine("║                    ERROR                     ║");
                    Console.WriteLine("╠══════════════════════════════════════════════╣");
                    Console.WriteLine("║  Invalid menu!                               ║");
                    Console.WriteLine("║  Please choose S for Smelt or B for         ║");
                    Console.WriteLine("║  Breakdown.                                  ║");
                    Console.WriteLine("╚══════════════════════════════════════════════╝");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("╔══════════════════════════════════════════════╗");
                Console.WriteLine("║                  ERROR                       ║");
                Console.WriteLine("╠══════════════════════════════════════════════╣");
                Console.WriteLine("║  Invalid amount!                             ║");
                Console.WriteLine($"║  Amount must be > 0 and <= {MaxBatch:F2}.        ║");
                Console.WriteLine("╚══════════════════════════════════════════════╝");
            }

            Console.WriteLine();
            Console.WriteLine("╔══════════════════════════════════════════════╗");
            Console.WriteLine("║          DRAGONFORGE SESSION CLOSED          ║");
            Console.WriteLine("║       May your next forge burn brighter.     ║");
            Console.WriteLine("╚══════════════════════════════════════════════╝");
            Console.WriteLine();
        }
    }
}
