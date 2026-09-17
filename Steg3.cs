List<string> names = new List<string>();
List<int> prices = new List<int>();

Console.Write("Skriv en vara: ");
string input = Console.ReadLine()!;

Console.Write("Pris: ");
string priceInput = Console.ReadLine()!;

int price = int.Parse(priceInput);

names.Add(input);
prices.Add(price);

Console.WriteLine("\nInköpslista:");

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine($"{i + 1}. {names[i]} - {prices[i]} kr");
}