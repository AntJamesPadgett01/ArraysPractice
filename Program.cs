using System;

namespace ArraysPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] UnluckyNumbers = { 21, 33, 13, 5, 90 };
            //                     //0   1   2   3  4// index

            UnluckyNumbers[1] = 875; // changed index 1 from (21) to (875)

            string[] friends = new string[5];
            friends[0] = "Jim";
            friends[1] = "Ricky";
            friends[2] = "Ralph";
            friends[3] = "Robert";
            friends[4] = "Cod";
            

            Console.WriteLine(UnluckyNumbers [1] ); // 90 index position 4
            





        }
    }
}
