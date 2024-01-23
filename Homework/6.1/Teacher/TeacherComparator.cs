class TeacherComparator : IComparer<Teacher>
{
    public int Compare(Teacher? x, Teacher? y)
    {
        if (x == null || y == null)
            return 0;
        int temp = x.Surname.CompareTo(y.Surname);
        if (temp == 0)
            return x.Name.CompareTo(y.Name);
        return temp;
    }
}