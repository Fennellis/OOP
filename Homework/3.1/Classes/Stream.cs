using System.Collections;

class Stream : IEnumerable, IComparable
{
    protected LinkedList<StudyGroup> studyGroups = new();
    public IEnumerator GetEnumerator()
    {
        foreach (var group in studyGroups)
        {
            yield return group;
        }
    }

    public LinkedList<StudyGroup> GetStudyGroups
    {
        get {return studyGroups;}
    }
    public void AddGroup(StudyGroup group)
    {
        studyGroups.AddLast(group);
    }

    public int Size
    {
        get {return studyGroups.Count;}
    }

    public override string ToString()
    {
        String temp = "[";
        foreach (var group in studyGroups)
        {
            temp += group.Name;
            temp += "; ";
        }
        temp = temp[..^2];
        temp += "]";
        return temp;
    }

    public int CompareTo(object? obj)
    {
        if(obj is Stream o) return studyGroups.Count.CompareTo(o.studyGroups.Count);
        else throw new ArgumentException("Некорректное значение параметра");
    }
}