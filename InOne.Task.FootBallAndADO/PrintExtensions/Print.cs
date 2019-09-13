using InOne.Task.FootBallAndADO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("PlayerID  TeamID   Name\tSurname  Number\t\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var item in p)
            {
                Console.WriteLine($"{item.Id}\t   {item.Team_Id} \t   {item.Name} {item.SurName} ({item.Number})");
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
    }
}
