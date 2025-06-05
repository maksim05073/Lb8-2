namespace LB8_2
{
    class Program
    {
        static void Main()
        {
            Suitcase suitcase = new Suitcase
            {
                Color = "Синій",
                Brand = "Samsonite",
                Weight = 3.5,
                Volume = 40 
            };

            SuitcaseHandler handler = new SuitcaseHandler();
            suitcase.OnItemAdded += handler.OnItemAddedMessage;

            try
            {
                suitcase.AddItem(new LuggageItem("Футболка", 2));
                suitcase.AddItem(new LuggageItem("Косметичка", 5));
                suitcase.AddItem(new LuggageItem("Ноутбук", 8));
                suitcase.AddItem(new LuggageItem("Кросівки", 10));
                suitcase.AddItem(new LuggageItem("Дрон", 20));
            }
            catch (VolumeExceededException ex)
            {
                Console.WriteLine($"\n[ПОМИЛКА] {ex.Message}");
            }

            suitcase.PrintInfo();
        }
    }
}