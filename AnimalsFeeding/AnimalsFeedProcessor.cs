using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsFeeding
{
    internal class AnimalsFeedProcessor : IDisposable
    {
        private List<AnimalPlace> _animalPlaces = new List<AnimalPlace>();
        public void AddNewAnimalPlace(AnimalPlace animalPlace)
        {
            _animalPlaces.Add(animalPlace);
            //subscribing to the event
            animalPlace.FoodFinished += FeedHandler;
        }

        public void FeedHandler(AnimalPlace sender, string food)
        {
            Console.WriteLine($"The {sender.Name} is hungry");
        }
        public void FeedAll()
        {
            foreach(AnimalPlace animal in _animalPlaces)
            {
                //feed 1 portion of food
                animal.Feed(1);
            }
        }
        public void Dispose()
        {
            foreach (AnimalPlace animalPlace in _animalPlaces)
            {
                animalPlace.FoodFinished -= FeedHandler;
            }
        }
    }
}
