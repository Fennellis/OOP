class LearningGroup : Group<Student>
{
    public LearningGroup(string groupName) : base(groupName)
    {}

    public override string ToString()
    {
        string temp = "student";
        if (Size > 1)
            temp += "s";
        return $"Learning group {Name}: {Size} {temp}";
    }
}