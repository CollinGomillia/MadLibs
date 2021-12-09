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
                        Console.Clear();
                        ChristmasTreeStory();
                        break;
                    case "2":
                        Console.Clear();
                        ChristmasBakingStory();
                        break;
                    case "3":
                        Console.Clear();
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




            Console.WriteLine("Enter month");
            input.Month = Console.ReadLine();


            int verbCount = 5;
            int verbDisplayCount = 5;

            List<string> verbs = new List<string>();
            for (int i = 0; i < verbCount; i++)
            {
                Console.WriteLine($"Please enter {verbDisplayCount} verbs");
                string userInput = Console.ReadLine();
                verbs.Add(userInput);
                verbDisplayCount -= 1;
            }
            input.Verbs = verbs;


            // Console.WriteLine($"verb1 {input.Verbs[0]}"); is example for story

            int placesCount = 2;
            int placesDisplayCount = 2;
           
            List<string> places = new List<string>();
            for (int i = 0; i < placesCount; i++)
            {
                Console.WriteLine($"Please enter {placesDisplayCount} places!");
                string userInput = Console.ReadLine();
                places.Add(userInput);
                placesDisplayCount -= 1;
            }
            input.Places = places;


            int adjectiveCount = 5;
            int adjectiveDisplayCount = 5;
            List<string> adjectives = new List<string>();
            for (int i = 0; i < adjectiveCount; i++)
            {
                Console.WriteLine($"Please enter {adjectiveDisplayCount} adjectives!");
                string userInput = Console.ReadLine();
                adjectives.Add(userInput);
                adjectiveDisplayCount -= 1;
            }
            input.Adjectives = adjectives;
           
           
            int colorCount = 1;
            int colorDisplayCount = 1;
            List<string> color = new List<string>();
            for (int i = 0; i < colorCount; i++)
            {
                Console.WriteLine($"Please enter {colorDisplayCount} color!");
                string userInput = Console.ReadLine();
                color.Add(userInput);
                colorDisplayCount -= 1;
            }
            input.Color = color;

            int nounCount = 3;
            int nounDisplayCount = 3;
            List<string> Nouns = new List<string>();
            for (int i = 0; i < nounCount; i++)
            {
                Console.WriteLine($"Please enter {nounDisplayCount} nouns!");
                string userInput = Console.ReadLine();
                Nouns.Add(userInput);
                nounDisplayCount -= 1;
            }
            input.Nouns = Nouns;


            Console.WriteLine("Enter a exclamation");
            input.Exclamation = Console.ReadLine();
            Console.WriteLine("Enter a holiday");
            input.Holiday = Console.ReadLine();
            #endregion

            //output
            #region

            Console.WriteLine("Press any button to read your story");
            Console.ReadLine();
            Console.WriteLine($"Every {input.Month} we {input.Verbs[0]} to a tree {input.Places[0]} far away. Not just any {input.Adjectives[0]} farm,\n" +
                $" a {input.Adjectives[1]} tree {input.Places[0]}. My dad and I {input.Verbs[1]} onto the {input.Nouns[0]} to {input.Verbs[2]} for the perfect {input.Nouns[1]}. \n" +
                $"Some people like them {input.Adjectives[2]} and {input.Adjectives[3]} and some like them {input.Color[0]} and fat. \n" +
                $"We are searching for a tall and {input.Adjectives[4]} one! Over there!, I exclaimed, Dad it's over there! \n" +
                $"Off we {input.Verbs[3]}, saw in hand to {input.Verbs[4]} this year's {input.Nouns[2]} down.\n" +
                $" {input.Exclamation} it's {input.Holiday} finally!\n");




            #endregion



        }

        private void ChristmasBakingStory()
        {


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
