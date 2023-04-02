using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create 3-4 videos and add comments to them
        Video video1 = new Video("Title 1", "Author 1", 120);
        video1.AddComment("Commenter 1", "This is a comment.");
        video1.AddComment("Commenter 2", "Another comment.");
        video1.AddComment("Commenter 3", "Yet another comment.");
        videos.Add(video1);

        Video video2 = new Video("Title 2", "Author 2", 180);
        video2.AddComment("Commenter 1", "This is a comment on video 2.");
        video2.AddComment("Commenter 2", "Another comment on video 2.");
        videos.Add(video2);

        Video video3 = new Video("Title 3", "Author 3", 240);
        video3.AddComment("Commenter 1", "This is a comment on video 3.");
        video3.AddComment("Commenter 2", "Another comment on video 3.");
        video3.AddComment("Commenter 3", "Yet another comment on video 3.");
        video3.AddComment("Commenter 4", "And one more comment on video 3.");
        videos.Add(video3);

        // Iterate through the list of videos and display their information
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("- " + comment.Name + ": " + comment.Text);
            }
            Console.WriteLine();
        }
    }
}