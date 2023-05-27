using System;

public class Video
{
    public string _title;
    public string _author;

    public int _length;
    public List<Comment> _comments = new List<Comment>();
    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length in Seconds: {_length}");

        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }

    public void GetCommentCount()
    {
        Console.WriteLine($"Number of comments: {_comments.Count}");
    }
}
