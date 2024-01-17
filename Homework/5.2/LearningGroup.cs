class LearningGroup
{
    private Teacher teacher;
    private List<Student> students = new();
    public LearningGroup(Teacher teacher)
    {
        this.teacher = teacher;
    }
    public Teacher GetTeacher{get {return teacher;}}
    public List<Student> GetStudents{get {return students;}}
    public bool Add(Student student)
    {
        if (!students.Contains(student))
        {
            students.Add(student);
            return true;
        }
        return false;
    }
    public bool Remove(Student student)
    {
        return students.Remove(student);
    }
    public void ChangeTeacher(Teacher teacher)
    {
        this.teacher = teacher;
    }
}