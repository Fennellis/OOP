class StreamComparator : IComparer<Stream>
{
    public int Compare(Stream? x, Stream? y)
    {
        if (x == null || y == null)
            return 0;
        return x.NumberOfGroups.CompareTo(y.NumberOfGroups);
    }
}