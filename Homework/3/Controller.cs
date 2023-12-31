class Controller
{
    public static void DeleteStudent(ref LearningGroup group, Student student)
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
}