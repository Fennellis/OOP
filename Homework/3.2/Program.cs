static void PrintGroup(LearningGroup group)
{
    foreach (var item in group)
    {
        System.Console.WriteLine(item);
    }
}

static void PrintStream(Stream stream)
{
    foreach (var item in stream)
    {
        System.Console.WriteLine(item);
    }
}

static void PrintListStreams(List<Stream> list)
{
    foreach (var stream in list)
    {
        System.Console.WriteLine(stream);
    }
}

Console.Clear();
System.Console.WriteLine("Заполнение 1 группы:");
Student student1 = new("Ivan", "Petrov", new(2000,12,17));
Student student2 = new("Petr", "Vladov", new(2001,02,07));
Student student3 = new("Vlad", "Sergeev", new(2000,11,23));
Student student4 = new("Sergey", "Ivanov", new(2001,01,30));
Student student5 = new("Sergey", "Petrov", new(2000,12,17));
Student student6 = new("Irina", "Ivanova", new(2001,03,12));

LearningGroup group1 = new("Group 1");
group1.AddStudent(student6);
group1.AddStudent(student3);
group1.AddStudent(student2);
group1.AddStudent(student5);
group1.AddStudent(student4);
group1.AddStudent(student1);

PrintGroup(group1);

System.Console.WriteLine("----------------------------------\n");
System.Console.WriteLine("Сортировка по ID:");

Controller.SortByID(ref group1);
PrintGroup(group1);

System.Console.WriteLine("----------------------------------\n");
System.Console.WriteLine("Удаление студента:");

Controller.DeleteStudent(ref group1, student3);
PrintGroup(group1);

System.Console.WriteLine("----------------------------------\n");
System.Console.WriteLine("Сортировка по ФИО:");

Controller.SortByFullName(ref group1);
PrintGroup(group1);

LearningGroup group2 = new("Group 2");
group2.AddStudent(student6);
group2.AddStudent(student3);
group2.AddStudent(student2);
group2.AddStudent(student5);
group2.AddStudent(student4);
group2.AddStudent(student1);

System.Console.WriteLine("----------------------------------\n");
System.Console.WriteLine("Создание потока:");

Stream stream1 = new("Stream 1");
stream1.AddGroup(group1);
stream1.AddGroup(group2);

PrintStream(stream1);

System.Console.WriteLine("----------------------------------\n");
System.Console.WriteLine("Создание списка потоков:");

Stream stream2 = new("Stream 2");
stream2.AddGroup(group2);

List<Stream> lst = new()
{
    stream1,
    stream2
};

PrintListStreams(lst);

System.Console.WriteLine("----------------------------------\n");
System.Console.WriteLine("Сортировка списка потоков:");

Controller.SortStreams(ref lst);

PrintListStreams(lst);