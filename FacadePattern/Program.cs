using System;
using FacadePattern.Facade;

namespace FacadePattern
{
    internal class Program
    {
        private static void Main()
        {
            var BigSandwitch = new BigSandwitch();
            BigSandwitch.Coock();

            Console.ReadLine();
        }
    }
}