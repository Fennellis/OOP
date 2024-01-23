using System.Globalization;

class LearningGroupService
{
    public void DeleteStudent(LearningGroup group)
    {
        String dateFormat = "dd.MM.yyyy";

        System.Console.Write("Введите фамилию студента: ");
        String? studentSurname = Console.ReadLine();

        System.Console.Write("Введите имя студента: ");
        String? studentName = Console.ReadLine();

        System.Console.Write("Введите дату рождения студента(дд.мм.гггг): ");
        String? birthdayStr = Console.ReadLine();
        while (birthdayStr == null)
        {
            System.Console.Write("Повторите ввод: ");
            birthdayStr = Console.ReadLine();
        }
        DateTime birthday = DateTime.ParseExact(birthdayStr, dateFormat, CultureInfo.InvariantCulture);

        if (studentSurname != null && studentName != null)
        {
            Student std = new Student(studentSurname, studentName, birthday);
            group.DeleteStudent(std);
        }
    }

    public LearningGroup Sort(LearningGroup group)
    {
        List<Student> students = new();
        foreach (Student student in group)
        {
            students.Add(student);
        }

        students.Sort();
        return new(group.GroupName, students);
    }

    public LearningGroup SortByFullName(LearningGroup group)
    {
        List<Student> students = new();
        foreach (Student student in group)
        {
            students.Add(student);
        }

        students.Sort(new StudentComparator());
        return new(group.GroupName, students);
    }
}