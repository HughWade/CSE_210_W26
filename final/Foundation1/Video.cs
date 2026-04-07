class Video

{
    public string _title;
    public string _author;
    public int _length;
    public int _likes;
    public List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length, int likes)
    {
        _title = title;
        _author = author;
        _length = length;
        _likes = likes;
    }

    public int ReturnNumOfComments()
    {
        return comments.Count;
    }

}