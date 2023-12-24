Stream stream1 = new Stream();

stream1.AddGroup(new StudyGroup("А-1", 37));
stream1.AddGroup(new StudyGroup("Б-1", 23));
stream1.AddGroup(new StudyGroup("В-1", 1));
stream1.AddGroup(new StudyGroup("Г-1", 53));


// System.Console.WriteLine(stream1);
// System.Console.WriteLine(stream1.Size);

// foreach (var item in stream)
// {
//     System.Console.WriteLine(item);
// }

Stream stream2 = new Stream();

stream2.AddGroup(new StudyGroup("А-2", 37));
stream2.AddGroup(new StudyGroup("Б-2", 23));
stream2.AddGroup(new StudyGroup("В-2", 1));
// stream2.AddGroup(new StudyGroup("wer4", 53));


// System.Console.WriteLine(stream2);
// System.Console.WriteLine(stream2.Size);

Stream stream3 = new Stream();

stream3.AddGroup(new StudyGroup("А-3", 37));
stream3.AddGroup(new StudyGroup("Б-3", 23));
stream3.AddGroup(new StudyGroup("В-3", 1));
stream3.AddGroup(new StudyGroup("Г-3", 53));
stream3.AddGroup(new StudyGroup("Д-3", 23));
stream3.AddGroup(new StudyGroup("Е-3", 1));

List<Stream> lst = new();
lst.Add(stream1);
lst.Add(stream3);
lst.Add(stream2);

foreach (var item in lst)
{
    System.Console.Write(item + " ");
}

// lst.Sort();
StreamService.Sort(lst);
System.Console.WriteLine();

foreach (var item in lst)
{
    System.Console.Write(item + " ");
}

