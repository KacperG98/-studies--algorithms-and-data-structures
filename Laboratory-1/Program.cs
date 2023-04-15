int BinarySearch(int target, List<int> collection)
{
    
    int halfOfList = collection.Count / 2;

    if (collection[halfOfList] < target)
    {
        return BinarySearch(target, collection.Skip(halfOfList).ToList());
    }
    else if (collection[halfOfList] > target)
    {
        return BinarySearch(target, collection.Take(halfOfList).ToList());
    }
    return collection[halfOfList];
}


var RangeList = Enumerable.Range(1, 100).ToList();
Console.WriteLine("Podaj liczbę jaką mam znaleźć z zagresu 1-100:");

int NumberToFind = Int32.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Znaleziona liczba to: {0}", BinarySearch(NumberToFind, RangeList));