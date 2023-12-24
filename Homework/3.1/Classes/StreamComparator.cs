class StreamComparator : IComparer<Stream>
{
    // public override int Compare(Stream? x, Stream? y)
    // {
    //     if (x.Size < y.Size)
    //         return -1;
    //     else if (x.Size == y.Size)
    //         return 0;
    //     else return 1;
    // }
    public int Compare(Stream? x, Stream? y)
    {
        if (x is not null && y is not null)
            return x.GetStudyGroups.Count - y.GetStudyGroups.Count;
        else throw new System.Exception();
    }
}