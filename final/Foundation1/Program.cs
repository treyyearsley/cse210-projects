using System;

class Program
{
    static void Main(string[] args)
    {
        Comment comment1 = new Comment();
        comment1._name = "Greg";
        comment1._comment = "This is the best video I have ever seen!";

        Comment comment2 = new Comment();
        comment2._name = "Luke";
        comment2._comment = "Kinda lame if you ask me.";

        Comment comment3 = new Comment();
        comment3._name = "Mark";
        comment3._comment = "Totally awesome!";

        Comment comment4 = new Comment();
        comment4._name = "Trevor";
        comment4._comment = "We should do a video together!";
        

        Video _video1 = new Video();
        _video1._title = "Youtube video";
        _video1._author = "Mark007";
        _video1._length = 87;

        _video1._comments.Add(comment1);
        _video1._comments.Add(comment2);
        _video1._comments.Add(comment3);
        _video1._comments.Add(comment4);
        comment1._videos.Add(_video1);
        

        _video1.Display();
        _video1.GetCommentCount();
        Console.WriteLine();

        Video _video2 = new Video();
        _video2._title = "Hard Core Parkour";
        _video2._author = "Mark007";
        _video2._length = 175;

        Comment comment5 = new Comment();
        comment5._name = "Bob";
        comment5._comment = "That was so sick!";

        Comment comment6 = new Comment();
        comment6._name = "Fred";
        comment6._comment = "I wish i could do that!";

        Comment comment7 = new Comment();
        comment7._name = "Randall";
        comment7._comment = "I could do thay easy!";

        _video2._comments.Add(comment7);
        _video2._comments.Add(comment6);
        _video2._comments.Add(comment5);
        comment1._videos.Add(_video2);

        _video2.Display();
        _video2.GetCommentCount();
        Console.WriteLine();

         Video _video3 = new Video();
        _video3._title = "Best Day of Shed Hunting Ever!";
        _video3._author = "Hooked on the Hunt";
        _video3._length = 456;

        Comment comment8 = new Comment();
        comment8._name = "Richard";
        comment8._comment = "We should put together a shed hunt!";

        Comment comment9 = new Comment();
        comment9._name = "Bill";
        comment9._comment = "Where did you go?";

        Comment comment10 = new Comment();
        comment10._name = "Lucas";
        comment10._comment = "The elk set is awesome!";

        _video3._comments.Add(comment8);
        _video3._comments.Add(comment9);
        _video3._comments.Add(comment10);
        comment1._videos.Add(_video3);

        _video3.Display();
        _video3.GetCommentCount();
        Console.WriteLine();
        
    }
}