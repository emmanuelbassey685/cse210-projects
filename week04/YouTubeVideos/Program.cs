using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Officer Black Belt", "Kim Woo-bin", 6485);
        Comment comment1 = new Comment("Bassey Emmanuel", "Highly Ineresting!");
        Comment comment2 = new Comment("Bassey Emmanuel", "Highly Ineresting!!");
        Comment comment3 = new Comment("Bassey Emmanuel", "Highly Ineresting!!!");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        videos.Add(video1);

        Video video2 = new Video("The 8 Night", "Lee Sung-min", 6900);
        Comment comment4 = new Comment("Bassey Emmanuel", "Highly Ineresting!");
        Comment comment5 = new Comment("Bassey Emmanuel", "Highly Ineresting!!");
        Comment comment6 = new Comment("Bassey Emmanuel", "Highly Ineresting!!!");
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        videos.Add(video2);

        Video video3 = new Video("The Point Men", "Hwang Jung-min", 6480);
        Comment comment7 = new Comment("Bassey Emmanuel", "Highly Ineresting!");
        Comment comment8 = new Comment("Bassey Emmanuel", "Highly Ineresting!!");
        Comment comment9 = new Comment("Bassey Emmanuel", "Highly Ineresting!!!");
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    
    }
}