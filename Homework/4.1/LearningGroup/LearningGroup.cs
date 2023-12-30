using System.Collections;

class LearningGroup : IEnumerable
{
    List<Student> group = new();
    private String groupName;

    public LearningGroup(String groupName) 
    {
        this.groupName = groupName;
    }
    public LearningGroup(String groupName, List<Student> inputList) : this(groupName)
    {
        group = inputList;
    }

    public String GroupName
    {
        get {return groupName;}
    }
    
    public int NumberOfStudents
    {
        get {return group.Count;}
    }

    public override string ToString()
    {
        return $"{groupName}: {group.Count} students";
    }

    public void AddStudent(Student student)
    {
        if (!group.Contains(student))
            group.Add(student);
    }

    public void DeleteStudent(Student student)
    {
        if (group.Contains(student))
            group.Remove(student);
    }

    public IEnumerator GetEnumerator()
    {
        return new LearningGroupIterator(group);
    }
}