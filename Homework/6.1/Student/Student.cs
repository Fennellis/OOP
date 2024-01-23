class Student : User, IComparable<Student>
{
    private static int id = 0;
    private int studentID;

    public Student(String name, String surname, DateTime birthday)
    : base(name, surname, birthday)
    {
        studentID = ++id;
    }
    public int ID
    {
        get {return studentID;}
    }

    public int CompareTo(Student? other)
    {
        if (other != null)
            return studentID - other.studentID;
        return 0;
    }

    public override bool Equals(object? obj)
    {
        if (obj is Student student)
            return student.Name == Name &&
                    student.Surname == Surname &&
                    student.Birthday == Birthday;
        else return false;
    }

    public override string ToString()
    {
        return $"ID {studentID} -> {Surname} {Name} {Birthday:d}";
    }

    public override int GetHashCode()
    {
        return studentID;
    }
}