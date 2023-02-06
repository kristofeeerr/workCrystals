using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workCrystals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int crystalPrice = 15;
            
            Console.WriteLine($" Добро пожаловать в магазин! Сегодня один кристалл стоит {crystalPrice} золотых монет:");
            Console.Write($"Сколько у вас золотых монет: " );
            int numberGoldCoins = Convert.ToInt32(Console.ReadLine());
            
            Console.Write($"Сколько кристаллов вам нужно:");
            int crystalCount = Convert.ToInt32(Console.ReadLine());

            numberGoldCoins -= crystalPrice * crystalCount;
            Console.WriteLine($"У вас {crystalCount} кристаллов и {numberGoldCoins} золотых монет");
        }
    }
}
