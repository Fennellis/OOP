class Controller<T> where T: User
{
    public static void Add(T user, Group<T> group)
    {
        group.Add(user);
    }
    public static void Remove(T user, Group<T> group)
    {
        group.Remove(user);
    }
    public static void Replace(T old, T actual, Group<T> group)
    {
        group.Replace(old, actual);
    }
    public static void Sort(Group<T> group)
    {
        group.Sort();
    }
}