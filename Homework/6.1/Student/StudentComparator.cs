class StudentComparator : IComparer<Student>
{
    public int Compare(Student? x, Student? y)
    {
        if (x == null || y == null)
            return 0;
        int temp = x.Surname.CompareTo(y.Surname);
        if (temp == 0)
            return x.Name.CompareTo(y.Name);
        return temp;
    }
}