using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MadLibs.POCO;


namespace MadLibs
{
    public class ProgramUI
    {



        private bool _isRunning = true;
        public void Run()
        {
            while (_isRunning)
            {
                RunMenu();
            }
        }

        private void RunMenu()
        {


            bool isAppRunning = true;
            while (isAppRunning)
            {
                Console.WriteLine("Welcome to Christmas MadLibs!!!! \n" +
                    "1. Oh Christmas Tree, Oh Christmas Tree \n" +
                    "2. Christmas Baking \n" +
                    "3. The Grinch \n" +
                    "4. The North Pole \n" +
                    "99. Exit Christmas MadLibs");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        ChristmasTreeStory();
                        break;
                    case "2":
                        ChristmasBakingStory();
                        break;
                    case "3":
                        GrinchStory();
                        break;
                    case "4":
                        NorthPoleStory();
                        break;
                    //
                    case "99":
                        isAppRunning = false;
                        Console.WriteLine("Thank you for playing Christmas MadLibs!!!");
                        break;
                    default:
                        Console.WriteLine("Please Choose one of the options.");
                        break;
                        //
                }

            }
        }

        private void ChristmasTreeStory()
        {
            //intake
            #region
            StoryWords input = new StoryWords();
            List<string> verbwords = new List<string>();


            Console.WriteLine("Enter month");
            input.Month = Console.ReadLine();

            int verbCount = 5;
            int displayCount = 5;

            for (int i = 0; i < verbCount; i++)
            {
                Console.WriteLine($"please {displayCount} enter Enter a verb");
                string userInput = Console.ReadLine();
                verbwords.Add(userInput);
                displayCount -= 1;
            }
            input.Verbs = verbwords;

            Console.WriteLine($"verb1 {input.Verbs[0]}");

            Console.WriteLine("Enter a place");
            input.Places[0] = Console.ReadLine();
            Console.WriteLine("Enter a adjective");
            input.Adjectives[0] = Console.ReadLine();
            Console.WriteLine("Enter a adjective");
            input.Adjectives[1] = Console.ReadLine();
            Console.WriteLine("Enter a place");
            input.Places[1] = Console.ReadLine();
            Console.WriteLine("Enter a verb");
            input.Verbs[1] = Console.ReadLine();
            Console.WriteLine("Enter a noun");
            input.Nouns[0] = Console.ReadLine();
            Console.WriteLine("Enter a verb");
            input.Verbs[2] = Console.ReadLine();
            Console.WriteLine("Enter a noun");
            input.Nouns[1] = Console.ReadLine();
            Console.WriteLine("Enter a adjective");
            input.Adjectives[2] = Console.ReadLine();
            Console.WriteLine("Enter a adjective");
            input.Adjectives[3] = Console.ReadLine();
            Console.WriteLine("Enter a color");
            input.Color[0] = Console.ReadLine();
            Console.WriteLine("Enter a adjective");
            input.Adjectives[4] = Console.ReadLine();
            Console.WriteLine("Enter a verb");
            input.Verbs[3] = Console.ReadLine();
            Console.WriteLine("Enter a verb");
            input.Verbs[4] = Console.ReadLine();
            Console.WriteLine("Enter a noun");
            input.Nouns[2] = Console.ReadLine();
            Console.WriteLine("Enter a exclamation");
            input.Exclamation = Console.ReadLine();
            Console.WriteLine("Enter a holiday");
            input.Holiday = Console.ReadLine();
            #endregion

            //output
            #region

            Console.WriteLine("Press any button to read your story");
            Console.ReadLine();
            Console.WriteLine($"Every {input.Month} we {input.Verbs[0]} to a tree {input.Places[0]} far away. Not just any {input.Adjectives[0]} farm, a {input.Adjectives[1]} tree {input.Places[0]}. My dad and I {input.Verbs[1]} onto the  ");

            Console.ReadLine();
            Console.Clear();


            #endregion



        }

        private void ChristmasBakingStory()
        {
            StoryWords input = new StoryWords();

            List<string> nouns = new List<string>();
            List<string> verbs = new List<string>();
            List<string> number = new List<string>();

            int nounCount = 8;
            int nounDisplayCount = 8;

            for (int i = 0; i < nounCount; i++)
            {
                Console.WriteLine($"Please enter 8 nouns. \n" +
                    $"You have {nounDisplayCount} nouns left to enter.");
                string nounUserInput = Console.ReadLine();
                nouns.Add(nounUserInput);
                nounDisplayCount -= 1;
                Console.Clear();
            }
            input.Nouns = nouns;

            Console.Clear();
            Console.WriteLine("Please enter a verb ending in ING.");
            string ingVerbInput = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Please enter an adjective.");
            string adjInput = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Please enter a family member.");
            string famMember = Console.ReadLine();

            Console.Clear();
            int verbCount = 2;
            int verbDisplayCount = 2;

            for (int i = 0; i < verbCount; i++)
            {
                Console.WriteLine($"Please enter 2 verbs. \n" +
                    $"You have {verbDisplayCount} verbs left to enter.");
                string verbUserInput = Console.ReadLine();
                verbs.Add(verbUserInput);
                verbDisplayCount -= 1;
                Console.Clear();
            }
            input.Verbs = verbs;

            Console.Clear();
            Console.WriteLine("Please enter an ingredient.");
            string ingredient = Console.ReadLine();

            Console.Clear();

            int numberCount = 2;
            int numberDisplayCount = 2;

            for (int i = 0; i < numberCount; i++)
            {
                Console.WriteLine($"Please enter 2 numbers. \n" +
                    $"You have {numberDisplayCount} numbers left to enter.");
                string numberUserInput = Console.ReadLine();
                number.Add(numberUserInput);
                numberDisplayCount -= 1;
                Console.Clear();
            }
            input.Numbers = number;

            Console.Clear();


            Console.WriteLine($"Every yea, we make {input.Nouns[0]} at Christmas time. \n" +
            $"{ingVerbInput} has been a tradition since I was a/an {adjInput} kid! \n" +
            $"{famMember} used to make most of the recipe back the, but I would always help {input.Verbs[0]} {ingredient}. \n" +
            $"Now that I'm older, I make the entire batch of {input.Nouns[1]} from scratch. \n" +
            $"All you have to do is mix {input.Nouns[2]} and {input.Nouns[3]} in a bowl until fluffy, and add {input.Nouns[4]}. \n" +
            $"Don't forget the {input.Nouns[5]}! \n" +
            $"{input.Verbs[1]} them on a {input.Nouns[6]} and bake them at {input.Numbers[0]} degrees. \n" +
            $"After {input.Numbers[1]} minutes, you will have the perfect {input.Nouns[7]}!");

        }
        private void GrinchStory()
        {
            StoryWords input = new StoryWords();
            #region
            int adjectiveCount = 2;
            int adjectiveDisplayCount = 2;

            List<string> adjectives = new List<string>();
            for (int i = 0; i < adjectiveCount; i++)
            {
                Console.WriteLine($"Please enter {adjectiveDisplayCount} adjectives!");
                string userInput = Console.ReadLine();
                adjectives.Add(userInput);
                adjectiveDisplayCount -= 1;
            }
            input.Adjectives = adjectives;

            int colorCount = 2;
            int colorDisplayCount = 2;

            List<string> colors = new List<string>();
            for (int i = 0; i < colorCount; i++)
            {
                Console.WriteLine($"Please enter {colorDisplayCount} colors!");
                string userInput = Console.ReadLine();
                colors.Add(userInput);
                colorDisplayCount -= 1;
            }
            input.Color = colors;

            Console.WriteLine("Enter a animal!");
            input.Animal = Console.ReadLine();

            int verbCount = 1;
            int verbDisplayCount = 1;

            List<string> verbs = new List<string>();
            for (int i = 0; i < verbCount; i++)
            {
                Console.WriteLine($"Please enter {verbDisplayCount} verb!");
                string userInput = Console.ReadLine();
                verbs.Add(userInput);
                verbDisplayCount -= 1;
            }
            input.Verbs = verbs;

            int nounCount = 1;
            int nounDisplayCount = 1;
            List<string> Nouns = new List<string>();
            for (int i = 0; i < nounCount; i++)
            {
                Console.WriteLine($"Please enter {nounDisplayCount} nouns!");
                string userInput = Console.ReadLine();
                Nouns.Add(userInput);
                nounDisplayCount -= 1;
            }
            input.Nouns = Nouns;

            int IngCount = 1;
            int IngDisplayCount = 1;
            List<string> IngVerb = new List<string>();
            for (int i = 0; i < IngCount; i++)
            {
                Console.WriteLine($"Please enter {IngDisplayCount} verbs ending in ing!");
                string userInput = Console.ReadLine();
                IngVerb.Add(userInput);
                IngDisplayCount -= 1;
            }
            input.IngVerb = IngVerb;

            int PluralCount = 3;
            int PluralDisplayCount = 3;
            List<string> PluralNouns = new List<string>();
            for (int i = 0; i < PluralCount; i++)
            {
                Console.WriteLine($"Please enter {PluralDisplayCount} plural nouns!");
                string userInput = Console.ReadLine();
                PluralNouns.Add(userInput);
                PluralDisplayCount -= 1;
            }
            input.PluralNouns = PluralNouns;
            #endregion

            #region
            Console.WriteLine("Press any button to read your story");
            Console.ReadLine();
            Console.WriteLine($"The Grinch is a(n) {input.Adjectives[0]} {input.Color[0]} creature with {input.Color[1]} eyes who does not like Christmas cheer.\n" +
                $" When he sees people celebrating Christmas, it makes him {input.Adjectives[1]}.\n" +
                $" He and his {input.Animal} Max try to {input.Verbs[0]} Christmas for people in the town of {input.Nouns[0]}-ville \n" +
                $" by their Christmas {input.PluralNouns[0]}. When the people \n" +
                $" still have Christmas cheer, even without {input.PluralNouns[1]}, the Grinch decides to return the {input.PluralNouns[2]} and celebrates \n" +
                $" Christmas after all. ");

            Console.ReadLine();
            Console.Clear();
            #endregion

        }
        private void NorthPoleStory()
        {
        }



    }
}
