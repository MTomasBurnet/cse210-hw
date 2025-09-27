using System;
using comment;

namespace video;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public Video()
    {

    }

    public int NumberOfComments()
    {
        return _comments.Count();
    }
    public void ShowVideo()
    {
        Console.WriteLine($"{_title} | {_author} | sec: {_length} | comments: {NumberOfComments()} \n");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine("");
    }
}