using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSQuiz
{
    internal class Questions
    {
        Program newProgram = new Program();
        public static void ActualQuiz(string name)
        {
            Console.Clear();
            int Correct = 0;
            string Q1 = "----------------------------------------" +
                        "\nQuestion One:" +
                        "\nWhich language is not a true object-oriented programming language?" +
                        "\n\nA) VB.Net" +
                        "\nB) Java" +
                        "\nC) C++" +
                        "\nD) C#" +
                        "\n----------------------------------------" +
                        "\n\nChoice: ";

            string Q2 = "----------------------------------------" +
                        "\nQuestion Two:" +
                        "\nWhich of the following is the correct output of the C#.Net code snippet given below?" +
                        "\nint[,,] a = new int[3,2,3];\nConsole.WriteLine(a.Length);" +
                        "\n\nA) 20" +
                        "\nB) 4" +
                        "\nC) 18" +
                        "\nD) 10" +
                        "\n----------------------------------------" +
                        "\n\nChoice: ";

            string Q3 = "----------------------------------------" +
                        "\nQuestion Three:" +
                        "\nWhich of the following statements is correct about Mangaged Code?" +
                        "\n\nA) Managed code is the code where resoruces are Garbage Collected." +
                        "\nB) Managed code is the code that runs on top of Windows." +
                        "\nC) Managed code is the code that can run on top of Linux." +
                        "\nD) Managed code is the code that is written to target the services of the CLR." +
                        "\n----------------------------------------" +
                        "\n\nChoice: ";

            string Q4 = "----------------------------------------" +
                        "\nQuestion Four:" +
                        "\nWhich of the .Net components can be used to remove unused references from the managed heap?" +
                        "\n\nA) Garbage Collector" +
                        "\nB) CLR" +
                        "\nC) Common Language Infrastructure" +
                        "\nD) Class Loader" +
                        "\n----------------------------------------" +
                        "\n\nChoice: ";

            string Q5 = "----------------------------------------" +
                        "\nQuestion Five:" +
                        "\nWhich of the following CANNOT occur multiple times in a program?" +
                        "\n\nA) Namespace" +
                        "\nB) Entry point" +
                        "\nC) Class" +
                        "\nD) Function" +
                        "\n----------------------------------------" +
                        "\n\nChoice: ";

            string Q6 = "----------------------------------------" +
                        "\nQuestion Six:" +
                        "\nWhich of the following is base namespace in the .Net Framework Class Library?" +
                        "\n\nA) System.IO" +
                        "\nB) Object" +
                        "\nC) System" +
                        "\nD) System.Base" +
                        "\n----------------------------------------" +
                        "\n\nChoice: ";

            string Q7 = "----------------------------------------" +
                        "\nQuestion Seven:" +
                        "\nName of Super class in C#.Net class Library?" +
                        "\n\nA) Base" +
                        "\nB) Object" +
                        "\nC) System" +
                        "\nD) Child" +
                        "\n----------------------------------------" +
                        "\n\nChoice: ";

            string Q8 = "----------------------------------------" +
                        "\nQuestion Eight:" +
                        "\nWhich of the following is NOT a namespace in the .Net Framework Class Library?" +
                        "\n\nA) System" +
                        "\nB) System.IO" +
                        "\nC) System.Process" +
                        "\nD) System.Threading" +
                        "\n----------------------------------------" +
                        "\n\nChoice: ";

            string Q9 = "----------------------------------------" +
                        "\nQuestion Nine:" +
                        "\nWhich of the following is not an application entry point?" +
                        "\n\nA) public static void Main() {}" +
                        "\nB) public static int Main() {}" +
                        "\nC) public static int Main(string[] args) {}" +
                        "\nD) public static int Main(string cmdline) {}" +
                        "\n----------------------------------------" +
                        "\n\nChoice: ";

            string Q10 = "----------------------------------------" +
                        "\nQuestion Ten:" +
                        "\nOn call of which type of method the new crated thread will not start executing?" +
                        "\n\nA) Begin()" +
                        "\nB) Start()" +
                        "\nC) New()" +
                        "\nD) All above" +
                        "\n----------------------------------------" +
                        "\n\nChoice: ";

            string[] Questions = { Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10 };
            string[] Answers = { "c", "c", "d", "a", "b", "c", "b", "c", "d", "b" };

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine(Questions[i]);
                string input = Console.ReadLine();
                string[] allowedAnswers = { "a", "b", "c", "d"};
                bool goodAnswer = false;
                for (int j = 0; j < allowedAnswers.Length; j++)
                {
                    if (input == allowedAnswers[j])
                    {
                        goodAnswer = true;
                    }
                }
                if (goodAnswer)
                {
                    if (input == Answers[i].ToLower())
                    {
                        Console.Clear();
                        Console.WriteLine("\nCorrect!");
                        Correct++;
                        PauseCode(2000);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\nIncorrect, the correct answer was \"" + Answers[i] + "\"");
                        PauseCode(2000);
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Error: Invalid Answer");
                    PauseCode(3000);
                    i--;
                }
                Console.Clear();
            }
            if (Correct <= 6)
            {
                Console.WriteLine("You got " + Correct + " questions right, you failed.");
                Console.WriteLine("You needed 6 or more to pass.");
                PauseCode(8000);
                Program.MainMenu(name);
            }
            else
            {
                Console.WriteLine("You got " + Correct + " questions right, you passed!");
                Console.WriteLine("You needed 6 or more to pass");
                PauseCode(8000);
                Program.MainMenu(name);
            }
        }
        static void PauseCode(int time)
        {
            System.Threading.Thread.Sleep(time);
        }
    }
}