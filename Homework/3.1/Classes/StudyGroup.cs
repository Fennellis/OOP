class StudyGroup
{
    protected String name = "N/A";
    protected int studentsNumber = 0;

    public StudyGroup(String name, int studentsNumber)
    {
        this.name = name;
        this.studentsNumber = studentsNumber;
    }

    public StudyGroup(){}

    public String Name
    {
        get {return name;}
    }

    public int Count
    {
        get {return studentsNumber;}
    }

    public override string ToString()
    {
        return $"name = {name}, students number = {studentsNumber}";
    }



    
}