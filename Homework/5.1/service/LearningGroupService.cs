class LearningGroupService
{
    public LearningGroup Create(Teacher teacher, List<Student> students)
    {
        return new(teacher, students);
    }
}