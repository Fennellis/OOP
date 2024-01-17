class Controller
{
    DataService ds = new();
    StudentView sv = new();
    LearningGroupService lgs = new();
    public void CreateStudent(string surname, string name, DateOnly birthday)
    {
        ds.Create<Student>(surname, name, birthday);
        foreach (User user in ds.Read())
        {
            if (user is Student student)
                sv.Show(student);
        }
    }
    public void CreateGroup(Teacher teacher, List<Student> students)
    {
        ds.AddGroup(lgs.Create(teacher, students));
    }
}