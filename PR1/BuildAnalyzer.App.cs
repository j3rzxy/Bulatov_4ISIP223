using System;
using BuildAnalyzer.Core;

namespace PR1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Core player = new Core();

            Console.WriteLine("Введите имя персонажа:");
            player.CharName = Console.ReadLine();
            Console.WriteLine("Введите базовую атаку:");
            player.BaseAttack = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите атаку оружия:");
            player.WeaponAttack = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите шанс критического удара:");
            player.CritChance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите критический урон в %:");
            player.CritDamageProc = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Имя вашего персонажа: {player.CharName}\n");
            double ra = player.ResultAttckC(); 
            Console.WriteLine($"Итоговая атака: {ra}");
            double cd = player.CritDamageC();
            Console.WriteLine($"Итоговая атака: {cd}");
            double avg = player.AvgDmgC();
            Console.WriteLine($"Итоговая атака: {avg}");
            string rate = player.Rating();
            Console.WriteLine($"Рейтинг сборки: {rate}");
        }
    }
}
