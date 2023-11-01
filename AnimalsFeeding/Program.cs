namespace AnimalsFeeding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //publisher
            AnimalPlace zhora = new AnimalPlace("lion", "meat");
            AnimalPlace tolya = new AnimalPlace("tiger", "chicken");
            using (AnimalsFeedProcessor processor = new AnimalsFeedProcessor())
            {
                processor.AddNewAnimalPlace(zhora);
                processor.AddNewAnimalPlace(tolya);
                zhora.Feed(2);
                processor.FeedAll();
            }
        }
    }
}