using System.Reflection;

class Controller
{
    DataService service;
    DataView view;
    public Controller(DataService service, DataView view)
    {
        this.service = service;
        this.view = view;
    }
    public void CreateUser()
    {
        Console.WriteLine("Выберите тип пользователя:");
        Type user = typeof(User);
        var userTypes = Assembly.GetAssembly(user).GetTypes().Where(type => type.IsSubclassOf(user));
        foreach (var item in userTypes)
        {
            System.Console.WriteLine(item);
        }
    }
    public void CreateGroup()
    {

    }
    public void AddToGroup()
    {

    }
}