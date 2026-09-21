/*
* Student ID : 1690701394
* Name       : Suwisit Dumdee
* Section    : 129B
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/
using System.Reflection.Metadata.Ecma335;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lives = 0;

            if (lives == 0)//ในวงเล็บคือเงื่อไขที่จะต้งเป็นจริง
            {
                // บล็อคของโค้ดที่จะทำง่น เมื่อเงื่อนไขเป็นจริง
                Console.WriteLine("Game Over");
            }

            //เมื่อเงื่อนไขทำงานเสร็จแล้ว หรือ เงี่อนไขไม่ตรงเลยโค้ดทำงานต่อ
            Console.WriteLine("Continue to Run");
        }
    }
}
