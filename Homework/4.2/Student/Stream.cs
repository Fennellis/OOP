using System.Collections;

class Stream : IEnumerable, IComparable
{
    List<LearningGroup> stream = new();
    public Stream(string streamName)
    {
        Name = streamName;
    }
    public string Name { get; }
    public int Size {get {return stream.Count;}}
    public void Add(LearningGroup group)
    {
        if (!stream.Contains(group))
        {
            stream.Add(group);
        }
            
    }
    public void Remove(LearningGroup group)
    {
        if (stream.Contains(group))
        {
            stream.Remove(group);
        }
    }
    public void Replace(LearningGroup old, LearningGroup actual)
    {
        if (stream.Contains(old))
        {
            stream.Remove(old);
            stream.Add(actual);
        }
    }
    public void Sort()
    {
        stream.Sort();
    }
    public IEnumerator GetEnumerator()
    {
        foreach (var item in stream)
        {
            yield return item;
        }
    }

    public int CompareTo(object? obj)
    {
        if (obj is Stream stream)
        {
            return Size.CompareTo(stream.Size);
        }
        else return 0;
    }
}