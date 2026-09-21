List<string> names = new List<string>();
List<int> prices = new List<int>();

while (true)
{
    Console.WriteLine("\nInköpslista:");

    int total = 0;

    for (int i = 0; i < names.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {names[i]} - {prices[i]} kr");
        total += prices[i];
    }

    Console.WriteLine($"Totalt: {total} kr");

    Console.Write("\nSkriv en vara eller ett nummer: ");
    string input = Console.ReadLine()!;

    if (int.TryParse(input, out int number))
    {
        int index = number - 1;

        if (index >= 0 && index < names.Count)
        {
            names.RemoveAt(index);
            prices.RemoveAt(index);

            Console.WriteLine("Varan har tagits bort.");
        }
        else
        {
            Console.WriteLine("Det numret finns inte i listan.");
        }
    }
    else
    {
        Console.Write("Pris: ");
        string priceInput = Console.ReadLine()!;

        if (int.TryParse(priceInput, out int price))
        {
            names.Add(input);
            prices.Add(price);

            Console.WriteLine("Varan har lagts till.");
        }
        else
        {
            Console.WriteLine("Priset måste vara ett heltal. Varan lades inte till.");
        }
    }
}