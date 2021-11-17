using System;
using System.Threading;

namespace Attentia.Dots.AsyncAwaitExample
{
    public class Dishes
    {
        public void CleanDishes(string secret)
        {
            var duration = new Random().Next(1000, 4000);
            Thread.Sleep(duration);

            Console.WriteLine($"cleaned some dishes for input '{secret}' ");
            return;

        }
    }
}
