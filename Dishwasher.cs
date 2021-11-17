using System.Threading.Tasks;

namespace AsyncAwaitExample
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
            return Task.Run(() => _dishes.CleanDishes(inputString));
        }
    }
}
