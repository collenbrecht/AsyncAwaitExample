using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncAwaitExample
{
    public class Person
    {
        private Dishes _dishes;
        private Dishwasher _dishwasher;

        public Person()
        {
            _dishes = new Dishes();
            _dishwasher = new Dishwasher();
        }

        public void DoDishes()
        {
            Console.WriteLine("Doing dishes");
            new Dishes().CleanDishes("Breakfast");
        }

        public void Read()
        {
            Console.WriteLine("Reading my favorite book");
        }

        public async Task DoDishesAsync(string dishesName)
        {
            Console.WriteLine("Starting the dishwasher");
            await _dishwasher.DoDishesTask(dishesName);
        }

        public async Task<string> DoManyDishesAsync(List<string> dishesNames)
        {
            var tasks = new List<Task>();
            foreach (var dishesName in dishesNames)
            {
                var task = _dishwasher.DoDishesTask(dishesName);
                tasks.Add(task);
            }
            await Task.WhenAll(tasks);
            return "All dishes are finished";
        }
    }
}
