
class Teacher : User
{
    private int teacherID;
    public Teacher(string surname, string name, DateOnly birthday) : base(surname, name, birthday)
    {
    }
    public override int GetID()
    {
        return teacherID;
    }
    public override void SetID(int id)
    {
        teacherID = id;
    }
    
    public override string ToString()
    {
        return base.ToString();
    }
}