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




            #endregion



        }

        private void ChristmasBakingStory()
        {
        }
        private void GrinchStory()
        {
        }
        private void NorthPoleStory()
        {
        }



    }
}
