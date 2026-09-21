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

