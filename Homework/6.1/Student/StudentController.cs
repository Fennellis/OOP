class StudentController : IUserController<Student>
{
    public static void DeleteStudent(Student student, LearningGroup group)
    {
        group.DeleteStudent(student);
    }

    public static void SortByID(ref LearningGroup group)
    {
        LearningGroupService service = new();
        group = service.Sort(group);
    }

    public static void SortByFullName(ref LearningGroup group)
    {
        LearningGroupService service = new();
        group = service.SortByFullName(group);
    }
    public static List<Stream> SortStreams(List<Stream> streams)
    {
        StreamService service = new();
        service.Sort(streams);
        return streams;
    }

    public void Create(Student user, LearningGroup group)
    {
        group.AddStudent(user);
    }

    public void SendOnConsole(List<Student> students)
    {
        new StudentView().SendOnConsole(students);
    }
}