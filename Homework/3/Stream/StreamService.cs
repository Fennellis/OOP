class StreamService
{
    public void Sort(List<Stream> stream)
    {
        stream.Sort(new StreamComparator());
    }
}