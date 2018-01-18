using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarations
            int[] questions = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            string[] answers = {"B", "D", "A", "A", "C","A","B","A", "C", "D", "B" , "C", "D", "A", "D", "C", "C", "B", "D", "A"};
            string [] studentChoice = new string[20];
            int[] questionHolder = new int[20];
            
            int correctHolder, incorrectHolder;
            int PASS_SCORE = 15;
            int x;
            string name, studentResponse;
            string exit = "exit";

            Console.WriteLine("This program will allow you to determine a students score by comparing their answers to the answer key");
            Console.WriteLine("To get started press enter");
            ConsoleKeyInfo start = Console.ReadKey();
            if(start.Key == ConsoleKey.Enter)
            {
                
                Console.WriteLine("Please enter the students name");
                name = Console.ReadLine();
                while (name != exit)
                {
                    correctHolder = 0;
                    incorrectHolder = 0;
                    for (x = 0; x < questions.Length; x++)
                    {
                        
                        Console.WriteLine("Please enter the students answer for questions number " + (x + 1));
                        studentResponse = Console.ReadLine().ToUpper();
                        while (studentResponse != "A" && studentResponse != "B" && studentResponse != "C" && studentResponse != "D")
                        {
                            Console.WriteLine("Invalid option, please enter a value between A-D");
                            studentResponse = Console.ReadLine().ToUpper();

                        }//endWhile
                        studentChoice[x] = studentResponse;

                        if (studentChoice[x] == answers[x])
                        {
                            correctHolder += 1;

                        }
                        else
                        {
                            incorrectHolder += 1;
                        }
                        questionHolder[x] = questionHolder[x] + incorrectHolder;

                    }//end for

                    if (correctHolder >= PASS_SCORE)
                    {
                        Console.WriteLine(name + " has passed the test with a score of " + correctHolder + " out of " + questions.Length);
                    }
                    else
                    {
                        Console.WriteLine(name + " did not pass the test");
                    }
                    Console.WriteLine("listed below is a list of the questions missed");
                    for (x = 0; x < questionHolder.Length; x++)
                    {
                        if (questionHolder[x] > 0)
                        {
                            Console.WriteLine(questions[x]);
                        }//endif
                    }//endfor
                
                

                    Console.WriteLine("Enter next students name to continue or 'exit' to close program");
                    name = Console.ReadLine();
                    

                }//endwhile
            }//endconsolekey
            Console.WriteLine("Thank you for using this program!");
   
        }//end of main
    }
}
