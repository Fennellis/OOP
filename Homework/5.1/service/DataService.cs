class DataService
{
    List<User> users;
    List<LearningGroup> groups = new();
    public DataService()
    {
        users = new();
    }
    public DataService(List<User> users)
    {
        this.users = users;
    }

    public void Create<T>(string surname, string name, DateOnly birthday) where T: User
    {
        if (typeof(T) == typeof(Student))
        {
            Student student = new Student(surname, name, birthday);
            student.SetID(GetMaxID<Student>(users) + 1);
            users.Add(student);
        }
        if (typeof(T) == typeof(Teacher))
        {
            Teacher teacher = new Teacher(surname, name, birthday);
            teacher.SetID(GetMaxID<Teacher>(users) + 1);
            users.Add(teacher);
        }
           
    }
    private int GetMaxID<T>(List<User> users) where T: User
    {
        int max = 0;
        foreach (User user in users)
        {
            if (user is T obj)
                if (obj.GetID() > max)
                    max = obj.GetID();
        }
        return max;
    }

    public List<User> Read()
    {
        return users;
    }
    public void AddGroup(LearningGroup group)
    {
        groups.Add(group);
    }
}