class Program
{
    static void Main(string[] args)
    {
        Video firstVideo = new Video("Get Ready With Me", "Bella Racelis", 720);
        Video secondVideo = new Video("ASMR McDo Mukbang", "Gongsam Table", 1080);
        Video thirdVideo = new Video("LAKERS vs SIXERS | NBA Full Game Highlights | December 25, 2026", "NBA", 1500);
        Video fourthVideo = new Video("I Want You | Official MV", "ENHYPEN", 180);

        firstVideo.AddComment(new Comment("Zyrlynn_00", "I love it! It's perfect for everyday look."));
        firstVideo.AddComment(new Comment("pwetty_Elizabeth", "Wow! Can we get the list of products you used?"));
        firstVideo.AddComment(new Comment("Joy", "You look so beautiful!!!"));
        
        secondVideo.AddComment(new Comment("123Kobe", "This video makes me hungry"));
        secondVideo.AddComment(new Comment("Aquaman101", "Currently watching this at 2:30 AM"));
        secondVideo.AddComment(new Comment("RiedNotReid", "Craving for some burgers rn."));

        thirdVideo.AddComment(new Comment("MJwannabe", "Great game on Christmas Day!"));
        thirdVideo.AddComment(new Comment("QGrimes", "That dunk by LeBron was mind blowing!"));
        thirdVideo.AddComment(new Comment("Draaaaymond", "I wish I was there to witness this game :("));

        fourthVideo.AddComment(new Comment("JakeyJakey15", "This is worth the wait!"));
        fourthVideo.AddComment(new Comment("HeeLeftTheGroup", "Can't wait to hear this in one of your concerts!!"));
        fourthVideo.AddComment(new Comment("Jongseongwifey", "My babies are soooo handsome!!"));

        List<Video> videos = new List<Video>
        {
            firstVideo,
            secondVideo,
            thirdVideo,
            fourthVideo
        };

        Console.WriteLine("Welcome to the YouTube Video Program!");
        Console.WriteLine();

        foreach (Video video in videos)
        {
            Console.WriteLine($"{video.GetTitle()} by {video.GetAuthor()} ({video.GetLength()}secs.)");
            Console.WriteLine($"Comments in this video: {video.CountComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()} - {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}