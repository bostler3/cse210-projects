public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();
    
    public int NumberOfComments()
    {
        int _numberOfComments = _comments.Count;
        return _numberOfComments;
    }
    
    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }
    
    public void Display()
    {
        Console.WriteLine($"{_title} by {_author} - {_length} seconds - {NumberOfComments()} comments");
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
}