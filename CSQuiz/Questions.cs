using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSQuiz {
    internal class Questions {
        Welcome newWelcome = new Welcome();
        public static void ActualQuiz(string name) {
            Console.Clear();
            int Correct = 0;
            string Q1 = "----------------------------------------" +
                        "\nQuestion One:" +
                        "\nWhat is 13 + 12?" +
                        "\n\nA) 43" +
                        "\nB) 12" +
                        "\nC) 25" +
                        "\nD) four" +
                        "\n----------------------------------------" +
                        "\n\nChoice: ";

            string Q2 = "----------------------------------------" +
                        "\nQuestion Two:" +
                        "\nHow to you spell zero?" +
                        "\n\nA) zero" +
                        "\nB) 0" +
                        "\nC) O" +
                        "\nD) ()" +
                        "\n----------------------------------------" +
                        "\n\nChoice: ";

            string Q3 = "----------------------------------------" +
                        "\nQuestion Three:" +
                        "\nWhat?" +
                        "\n\nA) No" +
                        "\nB) Sure?" +
                        "\nC) Maybe" +
                        "\nD) Ok" +
                        "\n----------------------------------------" +
                        "\n\nChoice: ";

            string Q4 = "----------------------------------------" +
                        "\nQuestion Four:" +
                        "\nFUCK!" +
                        "\n\nA) Fuck" +
                        "\nB) fUck" +
                        "\nC) fuCk" +
                        "\nD) fucK" +
                        "\n----------------------------------------" +
                        "\n\nChoice: ";

            string Q5 = "----------------------------------------" +
                        "\nQuestion Five:" +
                        "\nWhat is the answer to life." +
                        "\n\nA) 42" +
                        "\nB) 42" +
                        "\nC) 42" +
                        "\nD) 42" +
                        "\n----------------------------------------" +
                        "\n\nChoice: ";

            string Q6 = "----------------------------------------" +
                        "\nQuestion Six:" +
                        "\nWhat is the name of Marilyn Manson" + // I totally didn't finish this question but I'm too lazy to finish it.
                        "\n\nA) Dude, what the hell" +
                        "\nB) Portrait Of An American Family" +
                        "\nC) Man, oh man, wow" +
                        "\nD) AAAHHHHHHHHH" +
                        "\n----------------------------------------" +
                        "\n\nChoice: ";

            string[] Questions = {Q1, Q2, Q3, Q4, Q5, Q6};
            string[] Answers = {"c", "a", "a", "d", "b", "b"};

            for (int i = 0; i < Questions.Length; i++) {
                Console.WriteLine(Questions[i]);
                string input = Console.ReadLine();
                if (input == Answers[i].ToLower()) {
                    Console.WriteLine("\nCorrect!");
                    Correct++;
                }
                else {
                    Console.WriteLine("\nIncorrect, the correct answer was \"" + Answers[i] + "\"");
                }
                Console.Clear();
            }
            if (Correct < 4) {
                Console.WriteLine("You got " + Correct + " questions right, you failed.");
                Console.WriteLine("You needed 4 or more to pass.");
                PauseCode(8000);
                Welcome.MainMenu(name);
            }
            else {
                Console.WriteLine("You got " + Correct + " questions right, you passed!");
                Console.WriteLine("You needed 4 or more to pass");
                PauseCode(8000);
                Welcome.MainMenu(name);
            }
        }
        static void PauseCode(int time) {
            System.Threading.Thread.Sleep(time);
        }
    }
}
