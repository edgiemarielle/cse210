using System;

class Program
{
    static void Main(string[] args)
    {
        // I have added a prompt for the user to select a number to choose which scripture passage they would like to memorize. 
        Reference johnReference = new Reference("John", 3, 16);
        Reference proverbsReference = new Reference("Proverbs", 3, 5, 6);
        Reference almaReference = new Reference("Alma", 7, 11, 13);

        Console.WriteLine("Select a number to choose a scripture to memorize: ");
        Console.WriteLine($"1. {johnReference.GetDisplayText()}");
        Console.WriteLine($"2. {proverbsReference.GetDisplayText()}");
        Console.WriteLine($"3. {almaReference.GetDisplayText()}");

        string number = Console.ReadLine();
        Reference reference;
        string text;

        if (number == "1")
        {
            reference = johnReference;
            text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        }

        else if (number == "2")
        {
            reference = proverbsReference;
            text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        }

        else if (number == "3")
        {
            reference = almaReference;
            text = "11 And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people. And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities. Now the Spirit knoweth all things; nevertheless the Son of God suffereth according to the flesh that he might take upon him the sins of his people, that he might blot out their transgressions according to the power of his deliverance; and now behold, this is the testimony which is in me.";
        }

        else
        {
            Console.WriteLine("Invalid selection. Choose again.");
            return;
        }

        Scripture scripture = new Scripture(reference, text);

        Console.Clear();

        string response = "";

        while (!string.Equals(response, "quit", StringComparison.OrdinalIgnoreCase) && !scripture.IsCompletelyHidden())
        {
            Console.Write(reference.GetDisplayText() + " ");
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Please enter to continue or type 'quit' to finish: ");

            response = Console.ReadLine();

            if (string.Equals(response, "quit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
            else
            {
                scripture.HideRandomWords(3);
            }

            Console.Clear();
        }

        if (scripture.IsCompletelyHidden())
        {
            Console.Write(reference.GetDisplayText() + " ");
            Console.WriteLine(scripture.GetDisplayText());
        }
    }
}