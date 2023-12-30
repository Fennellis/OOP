class Specialization : Group<Teacher>
{
    public Specialization(string groupName) : base(groupName)
    {}
    public override string ToString()
    {
        string temp = "teacher";
        if (Size > 1)
            temp += "s";
        return $"Specialization {Name}: {Size} {temp}";
    }
}