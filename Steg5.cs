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

    Console.Write("\nSkriv en vara: ");
    string input = Console.ReadLine()!;

    Console.Write("Pris: ");
    string priceInput = Console.ReadLine()!;

    int price = int.Parse(priceInput);

    names.Add(input);
    prices.Add(price);

    Console.WriteLine("Varan har lagts till.");
}