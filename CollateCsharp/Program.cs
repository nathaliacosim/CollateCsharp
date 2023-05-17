public class Program
{
    private static void Main(string[] args)
    {
        IEnumerable<List<int>> vector = Arrayzada.Collate(new List<int> { 1, 2, 3, 4, 5 }, 3);
                
        Console.Write("[");
        foreach (List<int> a in vector)
        {
            Console.Write("[");
            foreach(int b in a)
            {
                Console.Write(b+", ");
            }
            Console.Write("],");
        }
        Console.Write("]");
    }
}

public class Arrayzada {
    public static IEnumerable<List<T>> Collate<T>(List<T> locations, int nSize = 30)
    {
        for (int i = 0; i < locations.Count; i += nSize)
        {
            yield return locations.GetRange(i, Math.Min(nSize, locations.Count - i));
        }
    }
}