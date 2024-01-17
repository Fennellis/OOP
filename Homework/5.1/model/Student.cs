
class Student : User
{
    private int studentID;
    public Student(string surname, string name, DateOnly birthday)
    : base(surname, name, birthday)
    {
    }

    public override int GetID()
    {
        return studentID;
    }
    public override void SetID(int id)
    {
        studentID = id;
    }
    public override string ToString()
    {
        return base.ToString();
    }

    
}