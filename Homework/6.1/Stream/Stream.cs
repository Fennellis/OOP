using System.Collections;

class Stream : IEnumerable
{
    List<LearningGroup> stream = new();
    private String streamName;

    public Stream(String streamName) 
    {
        this.streamName = streamName;
    }
    public Stream(String streamName, List<LearningGroup> inputList) : this(streamName)
    {
        stream = inputList;
    }
    public String StreamName
    {
        get {return streamName;}
    }
    
    public int NumberOfGroups
    {
        get {return stream.Count;}
    }

    public override string ToString()
    {
        return $"{streamName}: {stream.Count} groups";
    }

    public void AddGroup(LearningGroup group)
    {
        if (!stream.Contains(group))
            stream.Add(group);
    }

    public void DeleteGroup(LearningGroup group)
    {
        if (stream.Contains(group))
            stream.Remove(group);
    }

    public IEnumerator GetEnumerator()
    {
        return ((IEnumerable)stream).GetEnumerator();
    }
}