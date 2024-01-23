
class StudentView : IUserView<Student>
{
    public void SendOnConsole(List<Student> students)
    {
        foreach (var item in students)
        {
            System.Console.WriteLine(item);
        }
    }
}