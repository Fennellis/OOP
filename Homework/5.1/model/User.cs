abstract class User
{
    private string surname;
    private string name;
    private DateOnly birthday;
    public User(string surname, string name, DateOnly birthday)
    {
        this.surname = surname;
        this.name = name;
        this.birthday = birthday;
    }
    public string GetSurname{get {return surname;}}
    public string GetName{get {return name;}}
    public DateOnly GetBirthday{get {return birthday;}}

    public abstract int GetID();
    public abstract void SetID(int id);
    public override string ToString()
    {
        return $"{surname} {name} {birthday}";
    }
}