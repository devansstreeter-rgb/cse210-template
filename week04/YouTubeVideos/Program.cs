using System;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Comment aAlpha = new Comment("Andrew A.", "Wow, this reminds me of Star Trek: The Wrath of Khan");
        Comment aBeta = new Comment("Bethany B.", "This so fake, ngl");
        Comment aGamma = new Comment("Chris C.", "lol, first");
        List<Comment> aList = [aAlpha, aBeta, aGamma];
        Video toothpicks = new Video("How to Eat Toothpicks", "mr.PeachyPrune", 72, aList);
        
        Comment bAlpha = new Comment("Denise D.", "Anyone listening in 2024?");
        Comment bBeta = new Comment("Evan E.", "This takes me back to being a kid...endless summer days...eating Popsicles with ketchup...man, kids today will never know what we lost.");
        Comment bGamma = new Comment("Francis F.", "The cover is better, fight me");
        Comment bDelta = new Comment("Greg G.", "lol, first");
        List<Comment> bList = [bAlpha, bBeta, bGamma, bDelta];
        Video mayoSquelch = new Video("The Squelch of Mayonnaise (Radio Edit) - Bruce Hillsby", "Rehash Records", 233, bList);

        Comment cAlpha = new Comment("Hattie H.", "Such a brave boy. Thank you for helping him!");
        Comment cBeta = new Comment("Ivan I.", "I can't believe people actually do this. Humans are sick.");
        Comment cGamma = new Comment("Jane J.", "lol, first");
        Comment cDelta = new Comment("Kyle K.", "LOL, first");
        List<Comment> cList = [cAlpha, cBeta, cGamma, cDelta];
        Video savingPetri = new Video ("Saving an ABUSED Pet Rock - Meet Petri!!!", "TheNatureHero05", 657, cList);

        List<Video> videoList = [toothpicks, mayoSquelch, savingPetri];
        foreach (Video video in videoList)
        {
            Console.WriteLine($"\nThe video \"{video._title}\" by {video._author}\nis {video._length}s long and features the following comments:");
            foreach(Comment comment in video._comments)
            {
                Console.WriteLine($"{comment._name}: \"{comment._text}\"");
            }
        }

    }
}