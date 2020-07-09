using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Sentra", "Mustang", "Dart","Prius" };

            var carList = from car in cars
                          where car.Contains("r")
                          orderby car ascending
                          select car;

            foreach(var x in carList)
            {
                Console.WriteLine(x);
            }
        }
    }
}
