class Student : IComparable<Student>
{
    private String name;
    private String surname;
    private DateTime birthday;

    private static int id = 0;
    private int studentID;

    public Student(String name, String surname, DateTime birthday)
    {
        studentID = ++id;
        this.name = name;
        this.surname = surname;
        this.birthday = birthday;
    }
    public int ID
    {
        get {return studentID;}
    }

    public String Name
    {
        get {return name;}
    }

    public String Surname
    {
        get {return surname;}
    }

    public DateTime Birthday
    {
        get {return birthday;}
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
            return student.Name == this.name &&
                    student.Surname == this.surname &&
                    student.Birthday == this.birthday;
        else return false;
    }

    public override string ToString()
    {
        return $"ID {studentID} -> {surname} {name} {birthday:d}";
    }

    public override int GetHashCode()
    {
        return studentID;
    }
}