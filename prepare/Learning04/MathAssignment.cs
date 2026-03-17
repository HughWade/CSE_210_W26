class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbooksection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbooksection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"HOMEWORK LIST\nSection {_textbookSection}\nProblems {_problems}";
    }
}