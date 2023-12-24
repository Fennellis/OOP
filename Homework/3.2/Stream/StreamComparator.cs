class StreamComparator : IComparer<Stream>
{
    public int Compare(Stream? x, Stream? y)
    {
        return x.NumberOfGroups.CompareTo(y.NumberOfGroups);
    }
}