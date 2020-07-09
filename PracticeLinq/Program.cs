using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            //Query Style
            string[] cars = { "Sentra", "Mustang", "Dart","Prius" };

            var carList = from car in cars
                          where car.Contains("r")
                          orderby car ascending
                          select car;

            foreach(var x in carList)
            {
                Console.WriteLine(x);
            }

            //Method Style

            string[] vidGames = { "Astroids", "PacMan", "Robotron", "Joust" };

            var gameList = vidGames.OrderByDescending(x => x.Length);

            foreach (var x in gameList)
            {
                Console.WriteLine(x);
            }
        }
    }
}
