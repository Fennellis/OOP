
class Student : User
{
    private int studentID;
    public Student(string name, string surname, DateTime birthday)
    : base(name, surname, birthday)
    {
    }
    public int ID {get {return studentID;}
                   set {studentID = value;}}
}