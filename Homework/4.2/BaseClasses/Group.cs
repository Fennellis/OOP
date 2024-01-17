using System.Collections;

abstract class Group<T> : IEnumerable, IComparable where T: User
{
    private List<T> group = new();
    public Group(string groupName)
    {
        Name = groupName;
    }
    public string Name { get; }
    public int Size {get {return group.Count;}}
    public void Add(T user)
    {
        if (!group.Contains(user))
        {
            group.Add(user);
        }
           
    }
    public void Remove(T user)
    {
        if (group.Contains(user))
        {
            group.Remove(user);
        }
    }
    public void Replace(T old, T actual)
    {
        if (group.Contains(old))
        {
            group.Remove(old);
            group.Add(actual);
        }
    }
    public void Sort()
    {
        group.Sort();
    }

    public IEnumerator GetEnumerator()
    {
        foreach (var item in group)
        {
            yield return item;
        }
    }

    public int CompareTo(object? obj)
    {
        if (obj is Group<T> group)
        {
            return Size.CompareTo(group.Size);
        }
        else return 0;
    }
}