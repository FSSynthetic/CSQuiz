using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSQuiz
{
    internal class Program
    {
        Questions newQuestions = new Questions();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there, what's your name?");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            MainMenu(name);
        }

        public static void MainMenu(string name)
        {
            Console.Clear();
            Console.WriteLine(
                "\n\n" +
                "---------------------------------------------" +
                "\nWelcome to the quiz " + name + "!" +
                "\n\n" +
                "Select an option by choosing the number" +
                "\n1) Start Quiz" +
                "\n2) Quit" +
                "\n3) Credits" +
                "\n---------------------------------------------");
            Console.Write("Choice: ");
            string mainMenuChoice = Console.ReadLine();
            if (mainMenuChoice == "1")
            {
                StartQuiz(name);
            }
            else if (mainMenuChoice == "2")
            {
                Quit();
            }
            else if (mainMenuChoice == "3")
            {
                Credits(name);
            }
            else
            {
                MainMenu(name);
            }
        }

        static void StartQuiz(string name)
        {
            Console.Clear();
            Console.WriteLine(
                "\n\n" +
                "---------------------------------------------" +
                "\nAre you sure you\'re ready to start the quiz " + name + "?" +
                "\n\n" +
                "\n1) Yes" +
                "\n2) No" +
                "\n---------------------------------------------");
            Console.Write("Choice: ");
            string ToMainMenuChoice = Console.ReadLine();
            if (ToMainMenuChoice == "1")
            {
                Questions.ActualQuiz(name);
            }
            else if (ToMainMenuChoice == "2")
            {
                MainMenu(name);
            }
            else
            {
                Console.Clear();
                StartQuiz(name);
            }
        }

        static void Quit()
        {
            Console.Clear();
            Console.WriteLine("Thanks for playing!");
            PauseCode(3000);
            Environment.Exit(0);
        }

        static void Credits(string name)
        {
            Console.Clear();
            Console.WriteLine(
                "\n\n" +
                "---------------------------------------------" +
                "\nThanks for checking out my quiz " + name + "!" +
                "\n\nThis is my first take at a C# project as I continue to learn and attempt to master the language." +
                "\nIf there\'s something I could have done better or a nice trick you could add to this," +
                "\nplease let me know by creating a pr and I'll be more than happy to check it out." +
                "\n---------------------------------------------" +
                "\n\nCheck out my other projects here: github.com/FSSynthetic" +
                "\nConsider buying me a hot chocolate (I don\'t do coffee) here: buymeacoffee.com/FSSynthetic" +
                "\n---------------------------------------------");
            Console.WriteLine("Type \"Return\" to return to the main menu.");
            string CreditsChoice = Console.ReadLine();
            if (CreditsChoice.ToLower() == "return")
            {
                MainMenu(name);
            }
            else
            {
                Credits(name);
            }
        }
        static void PauseCode(int time)
        {
            System.Threading.Thread.Sleep(time);
        }
    }
}