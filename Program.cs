using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attentia.Dots.AsyncAwaitExample
{
    class Program
    {
        private static Person _person;

        static async Task Main(string[] args)
        {
            _person = new Person();

            //DoDishes();
            //await DoDishesAsync();
            await DoMultipleDishesAsync();
            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }

        private static void DoDishes()
        {
            _person.DoDishes();
            _person.Read();
        }

        private static async Task DoDishesAsync()
        {
            var task = _person.DoDishesAsync("Breakfast");
            _person.Read();
            await Task.WhenAll(task);
        }

        private static async Task DoMultipleDishesAsync()
        {
            var dishes = new List<string>
            {
                "breakfast",
                "lunch",
                "coffee",
                "dinner"
            };
            var allDishesTask = _person.DoManyDishesAsync(dishes);
            _person.Read();
            var taskreturn = await allDishesTask;
            Console.WriteLine(taskreturn);
        }

    }
}
