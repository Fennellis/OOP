using System.Collections;

class LearningGroupIterator : IEnumerator<Student>
{
    public List<Student> _students = new();
    int position = -1;

    public LearningGroupIterator(List<Student> students)
    {
        this._students = students;
    }
    public Student Current
    {
        get
        {
            try
            {
                return _students[position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }

    object IEnumerator.Current => Current;

    public void Dispose(){}

    public bool MoveNext()
    {
        position++;
        return position < _students.Count;
    }

    public void Reset()
    {
        position = -1;
    }
}