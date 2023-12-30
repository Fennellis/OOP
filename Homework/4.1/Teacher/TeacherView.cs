class TeacherView : IUserView<Teacher>
{
    public void SendOnConsole(List<Teacher> teachers)
    {
        foreach (var item in teachers)
        {
            System.Console.WriteLine(item);
        }
    }
}