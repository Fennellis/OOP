string path = "log.txt";
int countLogs = 7;

Interace(new(new(), new(), path), countLogs);

static void Interace(Controller ctrl, int countLogs)
{
    Console.Clear();

    while(true)
    {
        ConsoleKeyInfo key = ctrl.Menu();
        Console.Clear();
        switch (key.Key)
        {
            case ConsoleKey.D0:
                ctrl.Clear();
                break;
            case ConsoleKey.D1:
                ctrl.Add();
                break;
            case ConsoleKey.D2:
                ctrl.Sub();
                break;
            case ConsoleKey.D3:
                ctrl.Mul();
                break;
            case ConsoleKey.D4:
                ctrl.Div();
                break;
            case ConsoleKey.D5:
                ctrl.DumpLog(countLogs);
                break;
            case ConsoleKey.D6:
                ctrl.SetAccuracy();
                break;
            case ConsoleKey.Escape:
                return;
            default: break;
        }
        Console.Clear();
    }
}