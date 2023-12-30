abstract class User : IComparable
{
    string surname;
    string name;
    DateTime birthday;
    public User(String surname, string name, DateTime birthday)
    {
        this.surname = surname;
        this.name = name;
        this.birthday = birthday;
    }
    public string Surname {get {return surname;}}
    public string Name {get {return name;}}
    public DateTime Birthday {get {return birthday;}}

    public int CompareTo(object? obj)
    {
        if (obj is User user)
        {
            int temp = surname.CompareTo(user.surname);
            if (temp == 0)
            {
                temp = name.CompareTo(user.name);
                if (temp == 0)
                {
                    temp = birthday.CompareTo(user.birthday);
                }
            }
            return temp;
        }
        else return 0;
    }

    public override bool Equals(object? obj)
    {
        if (obj is User user)
        {
            return surname == user.surname && name == user.name && birthday == user.birthday;
        }
        else return false;
    }

    public override string ToString()
    {
        return $"{surname} {name} {birthday:d}";
    }

    public override int GetHashCode()
    {
        return surname.GetHashCode() + name.GetHashCode() + birthday.GetHashCode();
    }
}