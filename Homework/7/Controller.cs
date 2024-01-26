class Controller : IController
{
    private BaseService service;
    private BaseView view;
    private ComplexNumber lastResult;
    private int accuracy = 5;
    private string logPath;

    public Controller(BaseService service, BaseView view, string logPath)
    {
        this.service = service;
        this.view = view;
        lastResult = new(0, 0);
        this.logPath = logPath;
    }
    
    public ComplexNumber Result{get {return lastResult;}}
    public int Accuracy{get {return accuracy;}}
    public void SetAccuracy()
    {
        int? temp = view.SetAccuracy();
        if (temp != null)
            accuracy = (int)temp;
    }
    public ConsoleKeyInfo Menu()
    {
        return view.Menu(lastResult, accuracy);
    }
    public void Add()
    {
        (ComplexNumber, ComplexNumber) temp = Prepare();
        lastResult = service.Sum(temp.Item1,temp.Item2, accuracy);
        Log((temp.Item1, temp.Item2, lastResult), '+');
    }
    public void Sub()
    {
        (ComplexNumber, ComplexNumber) temp = Prepare();
        lastResult = service.Sub(temp.Item1,temp.Item2, accuracy);
        Log((temp.Item1, temp.Item2, lastResult), '-');
    }
    public void Mul()
    {
        (ComplexNumber, ComplexNumber) temp = Prepare();
        lastResult = service.Mul(temp.Item1,temp.Item2, accuracy);
        Log((temp.Item1, temp.Item2, lastResult), '*');
    }
    public void Div()
    {
        (ComplexNumber, ComplexNumber) temp = Prepare();
        ComplexNumber? tempNumber = service.Div(temp.Item1,temp.Item2, accuracy);
        if (tempNumber != null)
        {
            lastResult = tempNumber;
            Log((temp.Item1, temp.Item2, lastResult), '/');
        }
    }
    public void Clear()
    {
        lastResult = new(0,0);
    }
    private void Log((ComplexNumber, ComplexNumber, ComplexNumber) temp, char operation)
    {
        using StreamWriter w = File.AppendText(logPath);
        w.WriteLine($"({temp.Item1}) {operation} ({temp.Item2}) = {temp.Item3}");
    }
    public void DumpLog(int count)
    {
        using StreamReader r = File.OpenText(logPath);
        List<string> expressions = new();
        string? line;
        while ((line = r.ReadLine()) != null)
        {
            expressions.Add(line);
        }
        int startIndex = expressions.Count - count;
        if (startIndex < 0)
            startIndex = 0;
        view.ShowLogs(expressions.GetRange(startIndex, count));
    }
    private (ComplexNumber, ComplexNumber) Prepare()
    {
        ComplexNumber first;
        ComplexNumber second;

        if (lastResult.ToString() == "0")
            first = view.Input();
        else first = lastResult;
        second = view.Input();

        return (first,second);
    }
}