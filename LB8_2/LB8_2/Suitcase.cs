namespace LB8_2;

public class Suitcase
{
    public string Color { get; set; }
    public string Brand { get; set; }
    public double Weight { get; set; }      // Власна вага валізи
    public double Volume { get; set; }      // Загальний обсяг
    public List<LuggageItem> Contents { get; private set; }

    public delegate void AddItemHandler(LuggageItem item);
    public event AddItemHandler? OnItemAdded;

    public Suitcase() {
        Contents = new List<LuggageItem>();
    }

    // Додавання предмета у валізу з перевіркою об'єму
    public void AddItem(LuggageItem item) {
        double usedVolume = 0;
        foreach (var i in Contents) usedVolume += i.Volume;

        if (usedVolume + item.Volume > Volume)
            throw new VolumeExceededException($"Неможливо додати '{item.Name}' — перевищено обсяг валізи!");

        Contents.Add(item);
        OnItemAdded?.Invoke(item); // виклик події
    }

    // Метод для виводу інформації
    public void PrintInfo() {
        Console.WriteLine($"\nВаліза: {Color}, {Brand}, вага: {Weight} кг, об’єм: {Volume} л");
        Console.WriteLine("Вміст:");
        foreach (var item in Contents) {
            Console.WriteLine($" - {item}");
        }
    }
}