interface IUserView<T> where T: User
{
    public void SendOnConsole(List<T> users);
}