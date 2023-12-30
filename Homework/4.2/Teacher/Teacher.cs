class Teacher : User
{
    public Teacher(string surname, string name, DateTime birthday) : base(surname,name,birthday)
    {}
    public override bool Equals(object? obj)
    {
        if (obj is Teacher teacher)
            return base.Equals(teacher);
        return false;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}