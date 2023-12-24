class StreamService
{
    public void Sort(ref List<Stream> stream)
    {
        stream.Sort(new StreamComparator());
    }
}