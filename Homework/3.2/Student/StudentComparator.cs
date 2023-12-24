class StudentComparator : IComparer<Student>
{
    public int Compare(Student? x, Student? y)
    {
        int temp = x.Surname.CompareTo(y.Surname);
        if (temp == 0)
            return x.Name.CompareTo(y.Name);
        return temp;
    }
}