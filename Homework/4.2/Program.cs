Random rnd = new();
List<string> surnames = new() {"Ivanov", "Petrov", "Denisov"};
List<string> names = new() {"Ivan", "Petr", "Denis"};
int studentStart = 2005;
int studentEnd = 2006;
int TeacherStart = 1980;
int TeacherEnd = 1990;

List<string> streamNames = new() {"MT", "SM", "BMT", "RL"};

static void Print<T>(Group<T> group) where T: User
{
    System.Console.WriteLine(group);
    foreach (var item in group)
    {
        System.Console.WriteLine(item);
    }
}

static void PrintStream(Stream stream)
{
    System.Console.WriteLine(stream);
    foreach (var item in stream)
    {
        System.Console.WriteLine(item);
    }
}

LearningGroup CreateLearningGroup(int size, int groupNumber)
{
    LearningGroup group = new(groupNumber.ToString());
    for (int i = 0; i < size; i++)
    {
        int year = rnd.Next(studentStart, studentEnd + 1);
        int month = rnd.Next(1, 12 + 1);
        int day = rnd.Next(1, 28 + 1);
        DateTime randomData = new(year,month,day);

        Student student = new(surnames[new Random().Next(surnames.Count)],
                              names[new Random().Next(names.Count)],
                              randomData);

        group.Add(student);
    }
    group.Sort();
    return group;
}

Stream CreateStream(int size, string streamName)
{
    Stream stream = new(streamName);
    for (int i = 0; i < size; i++)
    {
        stream.Add(CreateLearningGroup(rnd.Next(15, 25 + 1), i + 1));
    }
    return stream;
}

Specialization CreateSpecialization(int size, string SpecializationName)
{
    Specialization specialization = new(SpecializationName);
    for (int i = 0; i < size; i++)
    {
        int year = rnd.Next(TeacherStart, TeacherEnd + 1);
        int month = rnd.Next(1, 12 + 1);
        int day = rnd.Next(1, 28 + 1);
        DateTime randomData = new(year,month,day);
        specialization.Add(new(surnames[new Random().Next(surnames.Count)],
                              names[new Random().Next(names.Count)],
                              randomData));
    }
    return specialization;
}

LearningGroup group1 = CreateLearningGroup(10, 1);
Print(group1);

System.Console.WriteLine("-----------------------------");

Stream stream = CreateStream(rnd.Next(3, 5 + 1), streamNames[rnd.Next(streamNames.Count)]);
PrintStream(stream);

System.Console.WriteLine("-----------------------------");

Specialization math = CreateSpecialization(3, "Math");
Print(math);