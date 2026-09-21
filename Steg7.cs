List<string> names = new List<string>();
List<int> prices = new List<int>();

Console.Write("Skriv en vara eller ett nummer: ");
string input = Console.ReadLine()!;

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