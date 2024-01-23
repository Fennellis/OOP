class User
{
    private String name;
    private String surname;
    private DateTime birthday;

    public User(String name, String surname, DateTime birthday)
    {
        this.name = name;
        this.surname = surname;
        this.birthday = birthday;
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
}