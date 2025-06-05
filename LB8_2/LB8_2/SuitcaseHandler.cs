namespace LB8_2;

public class SuitcaseHandler
{
    public void OnItemAddedMessage(LuggageItem item) {
        Console.WriteLine($"[Подія] Додано предмет: {item}");
    }
}