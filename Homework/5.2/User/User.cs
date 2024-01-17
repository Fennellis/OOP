abstract class User
{
    private string name;
    private string surname;
    private DateTime birthday;
    public User(string name, string surname, DateTime birthday)
    {
        this.name = name;
        this.surname = surname;
        this.birthday = birthday;
    }
}