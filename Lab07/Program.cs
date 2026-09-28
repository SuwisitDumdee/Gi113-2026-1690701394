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
           int classId = 1;

            string weapon = classId switch
            {
                1 => "Sword",
                2 => "Staff",
                3 => "Bow",
                _ => "fists"
            };
        }
    }
}
