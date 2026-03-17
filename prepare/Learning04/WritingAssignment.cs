class WritingAssignement : Assignment
{
    private string _title;

    
    public WritingAssignement(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    
    
    public string GetWritingInformation()
    {
       return $"WRITING INFORMATION\n{_title} by {_studentName}"; 
    }
}