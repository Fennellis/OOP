class Teacher : User, IComparable<Teacher>
{
    private static int id = 0;
    private int TeacherID;

    public Teacher(String name, String surname, DateTime birthday)
    : base(name, surname, birthday)
    {
        TeacherID = ++id;
    }
    public int ID
    {
        get {return TeacherID;}
    }

    public int CompareTo(Teacher? other)
    {
        if (other != null)
            return TeacherID - other.TeacherID;
        return 0;
    }

    public override bool Equals(object? obj)
    {
        if (obj is Teacher teacher)
            return teacher.Name == Name &&
                    teacher.Surname == Surname &&
                    teacher.Birthday == Birthday;
        else return false;
    }

    public override string ToString()
    {
        return $"ID {TeacherID} -> {Surname} {Name} {Birthday:d}";
    }

    public override int GetHashCode()
    {
        return TeacherID;
    }
}