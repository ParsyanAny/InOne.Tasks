using InOne.Task.FootBallAndADO.Models;
using System;
using System.Collections.Generic;

namespace InOne.Task.FootBallAndADO.PrintExtensions
{
    public static class Print
    {
        public static void PrintTeam(this IEnumerable<Team> t)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Team ID\t Coach ID\tTeam Name\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var item in t)
            {
                Console.WriteLine($"{item.Id}\t {item.Coach_Id} \t\t{item.Name}");
            }
            Console.ResetColor();
        }
        public static void PrintPlayer(this IEnumerable<Player> p)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("PlayerID  TeamID   Name\tSurname  Number\t FootSize\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var item in p)
            {
                Console.WriteLine($"{item.Id}\t   {item.Team_Id} \t   {item.Name} {item.SurName}({item.Number})\t  {item.FootSize}");
            }
            Console.ResetColor();
        }
        public static void PrintCoach(this IEnumerable<Coach> c)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("CoachID  FullName \tAge\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var item in c)
            {
                Console.WriteLine($"{item.Id} \t{item.FullName}   {item?.Age}");
            }
            Console.ResetColor();
        }
        public static void PrintBrandNames(this IEnumerable<BrandName> bn)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("BrandNameID  Name\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var item in bn)
            {
                Console.WriteLine($"{item.Id}  \t     {item.Name}");
            }
            Console.ResetColor();
        }
        public static void PrintShoes(this IEnumerable<Shoes> sh)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("ShoesID  BrandNameId  Player_Id  Price  Size  DateOfCreation\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var item in sh)
            {
                Console.WriteLine($"{item.Id}  \t {item.BrandName_Id}\t      {item.Player_Id}\t\t {item.Price}\t{item.Size}    {item.DateOfCreation}");
            }
            Console.ResetColor();
        }
    }
}
