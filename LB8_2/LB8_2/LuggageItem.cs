namespace LB8_2;

public class LuggageItem
{
    public string Name { get; set; }
    public double Volume { get; set; }

    public LuggageItem(string name, double volume) {
        Name = name;
        Volume = volume;
    }

    public override string ToString() => $"{Name} ({Volume} л)";
}