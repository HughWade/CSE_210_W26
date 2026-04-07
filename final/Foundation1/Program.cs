using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        Video video1 = new Video("Mark Zuckerberg Interview", "Diary of a CEO", 32, 754);
        Comment comment11 = new Comment("John Smith", "Interesting interview. Very informative.");
        Comment comment12 = new Comment("Hank Jankers", "I wish it was longer.");
        Comment comment13 = new Comment("Jacob LaPlant", "Get his guy on again.");
        Comment comment14 = new Comment("Hailey Scarborough", "I wish they had talked about the Iran conflict for longer.");
        video1.comments.Add(comment11);
        video1.comments.Add(comment12);
        video1.comments.Add(comment13);
        video1.comments.Add(comment14);

        Video video2 = new Video("Dogs Sneezing Compilation", "DOGS4LIFE", 16, 345);
        Comment comment21 = new Comment("Chloe Johnson", "They are soooo cute!");
        Comment comment22 = new Comment("Chris Williamson", "Waste of time.");
        Comment comment23 = new Comment("Blake Ostler", "Read the Book of Mormon instead of watching this.");
        video2.comments.Add(comment21);
        video2.comments.Add(comment22);
        video2.comments.Add(comment23);


        Video video3 = new Video("Artemis II Test Launch", "NASA", 13, 435);
        Comment comment31 = new Comment("Mark Zuckerberg","Great Work! So excited for our return to the moon!");
        Comment comment32 = new Comment("Joe Rogan", "Y'all should come on my podcast :)");
        Comment comment33 = new Comment("Alex O'Connor", "The future is now.");
        Comment comment34 = new Comment("Dike Smallson", "Why the name Artemis?");
        video3.comments.Add(comment31);
        video3.comments.Add(comment32);
        video3.comments.Add(comment33);
        video3.comments.Add(comment34);


        Video video4 = new Video("Gordan Ramsey Crashes Out While Eating Spicy Wings", "Hot Ones", 26, 754);
        Comment comment41 = new Comment("Jacob Hansen", "Halarious!");
        Comment comment42 = new Comment("Gordan Ramsey", "Golly this was a tough one.");
        Comment comment43 = new Comment("Cam Reynolds", "I could've eaten those wings any day.");
        video4.comments.Add(comment41);
        video4.comments.Add(comment42);
        video4.comments.Add(comment43);

        videoList.Add(video1);
        videoList.Add(video2);
        videoList.Add(video3);
        videoList.Add(video4);

        foreach (Video video in videoList)
        {
            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine($"Video Title: {video._title}");
            Console.WriteLine($"Video Author: {video._author}");
            Console.WriteLine($"Video Length: {video._length} mins");
            Console.WriteLine($"Number of Comments: {video.ReturnNumOfComments()}");
            Console.WriteLine($"Number of Likes: {video._likes}");
            
            foreach (Comment comment in video.comments)
            {
                Console.WriteLine($"\nCommenter Name: {comment._name}");
                Console.WriteLine($"Comment: {comment._theirComment}");
            }
        }

    }
}