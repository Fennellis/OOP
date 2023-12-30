class Student : User
{
    static int id = 0;
    private int studentID;
    private string currentGroup = "N/A";
    public Student(string surname, string name, DateTime birthday)
    : base(surname, name, birthday)
    {
        studentID = ++id;
    }
    public int ID {get {return studentID;}}
    public string CurrentGroup {get {return currentGroup;}}
    public override bool Equals(object? obj)
    {
        if (obj is Student student)
            return base.Equals(student);
        return false;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}