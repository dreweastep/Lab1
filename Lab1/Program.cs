using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] correctAnswers;
            string[] givenAnswers;
            bool[] answerState;
            bool exitCondition;
            string exit;
            string answer;
            int i;
            int score;
            int passingScore = 15;


            correctAnswers =  new string[20] {"B", "D", "A", "A", "C",
                                              "A", "B", "A", "C", "D",
                                              "B", "C", "D", "A", "D",
                                              "C", "C", "B", "D", "A" };
            
            exitCondition = true;
            while (exitCondition == true)
            {
                Console.WriteLine("Do you wish to enter test scores? (y/n)");
                exit = Console.ReadLine();
                if (exit == "n")
                {
                    break;
                }
                else
                {
                    givenAnswers = new string[20] {"", "", "", "", "",
                                                   "", "", "", "", "",
                                                   "", "", "", "", "",
                                                   "", "", "", "", "" };

                    answerState = new bool[20] {false, false, false, false, false,
                                                false, false, false, false, false,
                                                false, false, false, false, false,
                                                false, false, false, false, false };

                    Console.WriteLine("Enter answers:");
                    for (i = 0; i < 20; i++)
                    {
                        Console.WriteLine("Question {0}:", i+1);
                        answer = Console.ReadLine().ToUpper();
                        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
                        {
                            Console.WriteLine("Invalid option, Please enter 'A', 'B', 'C', 'D'.");
                            Console.WriteLine("Question {0}:", i + 1);
                            answer = Console.ReadLine().ToUpper();
                        }
                        givenAnswers[i] = answer;
                        if (givenAnswers[i] == correctAnswers[i])
                        {
                            answerState[i] = true;
                        }
                    }
                    score = 0;
                    foreach(bool x in answerState)
                    {
                        if (x == true)
                        {
                            score++;
                        }
                    }
                    Console.WriteLine();

                    if (score >= passingScore)
                    {
                        Console.WriteLine("You Passed!!");
                    }
                    else
                    {
                        Console.WriteLine("You Failed. :(");
                    }

                    Console.WriteLine("Number of correctly answered questions: {0}", 
                                       score);
                    Console.WriteLine("Number of incorrectly answered questions: {0}",
                                       (20 - score));
                    Console.WriteLine("Incorrectly answered questions:");
                    for (i = 0; i < 20; i++)
                    {
                        if (answerState[i] == false)
                        {
                            Console.WriteLine("Question {0}", i + 1);
                        }
                    }
                    Console.WriteLine();
                }

            }

        }
    }
}
