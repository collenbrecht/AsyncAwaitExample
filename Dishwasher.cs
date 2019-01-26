using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attentia.Dots.AsyncAwaitExample
{
    public class Dishwasher
    {
        private Dishes _dishes;

        public Dishwasher()
        {
            _dishes = new Dishes();
        }
        public Task DoDishesTask(string inputString)
        {
            return Task.Run(() => _dishes.CleanDishes(inputString, Guid.NewGuid().ToString()));
        }
    }
}
