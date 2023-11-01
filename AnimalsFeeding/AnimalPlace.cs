using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsFeeding
{
    internal class AnimalPlace
    {
        public string Name { get; }
        public string FoodName { get; }
        public event Action<AnimalPlace, string> FoodFinished;
        public AnimalPlace(string name, string food) 
        {
            Name = name;
            FoodName = food;
        }
        public void Feed(int amount)
        {
            Console.WriteLine($"The {Name} was fed with {amount} portion of {FoodName}.");
            //if FoodFinished has a subscriber it is not null and we have a pointer to an event handler
            if (FoodFinished != null)
            {
                FoodFinished(this, FoodName);
            }
        }
    }
}
