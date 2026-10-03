using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video firstVideo = new Video("Christ-Centered Teaching", "Christian Mavinga", 600);
        Video secondVideo = new Video("Youth Mobilization Event", "Limete Stake", 450);
        Video thirdVideo = new Video("Seminary Orientation", "Kintambo Institute", 720);

        firstVideo.AddComment(new Comment("Blondine", "Great message!"));
        firstVideo.AddComment(new Comment("Bob", "It was very inspiring."));
        firstVideo.AddComment(new Comment("Imera", "I loved the scripture references."));

        secondVideo.AddComment(new Comment("Ilunga", "This event looks amazing."));
        secondVideo.AddComment(new Comment("Fils", "Thank you for organizing!"));
        secondVideo.AddComment(new Comment("Patrick", "I can’t wait for the next one."));

        thirdVideo.AddComment(new Comment("Arcel", "Helpful orientation."));
        thirdVideo.AddComment(new Comment("Gamel", "Clear explanations."));
        thirdVideo.AddComment(new Comment("Clarisse", "I'm looking forward to classes."));

        List<Video> videos = new List<Video> { firstVideo, secondVideo, thirdVideo };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.VideoLength} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"   {comment.personComment}: {comment.CommentContent}");
            }
            Console.WriteLine(); 
        }
    }
}
