using System;
using System.Collections.Generic;

namespace ShoppingCart1
{
    class Program
    {
        static void Main(string[] args)
        {
            // dotnet run 1,2 3,4 5,6
            var list = new List<int>{100, 40, 150, 350, 400, 420, 440, 100, 80, 100};
            var totalAmount = 0;
            foreach(string arg in args){
                string[] idAndNum = arg.Split(",");
                if( !int.TryParse(idAndNum[0],out int id) ) continue;
                if( !int.TryParse(idAndNum[1],out int num) ) continue;
                totalAmount += list[id - 1] * num;
            }
            Console.WriteLine(totalAmount);
        }
    }
}
