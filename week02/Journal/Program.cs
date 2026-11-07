using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journalEntry = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";

        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Select one of the following choices to start: ");

        while (choice != "6")
        {
            Console.WriteLine("1. Write a journal entry");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load journal entry");
            Console.WriteLine("4. Save journal entry");
            Console.WriteLine("5. Add Reminder");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine(prompt);
                Console.Write(">");
                string response = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = response;

                journalEntry.AddEntry(entry);
                Console.WriteLine("Journal entry saved.");
            }

            else if (choice == "2")
            {
                journalEntry.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.Write("Enter a filename to load: ");
                string loadFilename = Console.ReadLine();
                journalEntry.LoadFromFile(loadFilename);
            }

            else if (choice == "4")
            {
                Console.Write("Enter a filename to save your journal entry: ");
                string filename = Console.ReadLine();
                journalEntry.SaveToFile(filename);
            }

            // To exceed the requirements, I added this as a reminder for the user to come back the next day and keep track of their journal. As someone who struggles as well in keeping track of my journal, a reminder would help me to consistently do it.
            else if (choice == "5")
            {
                DateTime reminder = DateTime.Today.AddDays(1);

                Random random = new Random();

                int randomHour = random.Next(0, 24);
                int randomMinute = random.Next(0, 60);

                DateTime randomTimeTomorrow = reminder
                    .AddHours(randomHour)
                    .AddMinutes(randomMinute);

                Console.WriteLine($"Just a reminder to comeback tomorrow at {randomTimeTomorrow:hh:mm tt} to keep track of your journal :)");
            }

            else if (choice == "6")
            {
                Console.WriteLine("Bye!");
            }

            else
            {
                Console.WriteLine("Invalid choice. Please choose again.");
            }
        }
    }
}