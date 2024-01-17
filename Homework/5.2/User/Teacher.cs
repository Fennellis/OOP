
class Teacher : User
{
    private int teacherID;
    public Teacher(string name, string surname, DateTime birthday) : base(name, surname, birthday)
    {
    }
    public int ID {get {return teacherID;}
                   set {teacherID = value;}}
}