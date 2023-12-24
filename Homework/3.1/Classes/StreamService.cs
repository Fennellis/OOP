abstract class StreamService
{
    private static StreamComparator comparator = new();
    public static void Sort(List<Stream> coll)
    {
        coll.Sort(comparator);
    }
}