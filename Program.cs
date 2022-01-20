using System;

namespace EnthusiasticMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
            Console.WriteLine("--------------------------------------------");


            // Let the moose speak!
            MooseSays("H I, I'M E N T H U S I A S T I C! ", "Hi, I REALLY am enthusiastic!");

            // As a question
            QuestionRefactor("Are Oceania, Eurosia, and Eastasia real?", "Really? It seems very unlikely.  Have you read 1984? ", "Really? It seems very unlikely.  Have you read 1984? ");
             QuestionRefactor("Are you enthusiastic?", "Yay!", "You should try it!" );
            // QuestionRefactor("Do you love C# yet?");
            SecretQuestion();
        }

        static void QuestionRefactor(string questionToAsk, string ifYes, string ifNO)
        {
            // if (questionToAsk == "Are Oceania, Eurosia, and Eastasia real?")
            // {
                bool isTrue = MooseAsks(questionToAsk);
                if (isTrue)
                {
                    MooseSaysThis(ifYes);
                }
                else
                {
                    MooseSaysThis(ifNO);
                }
            // }
            // else if (questionToAsk == "Are you enthusiastic?")
            // {
            //     bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
            //     if (isEnthusiastic)
            //     {
            //         MooseSaysThis("Yay!");
            //     }
            //     else
            //     {
            //         MooseSaysThis("You should try it!");
            //     }
            // }
            // else if (questionToAsk == "Do you love C# yet?")
            // {
            //     bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
            //     if (doesLoveCSharp)
            //     {
            //         MooseSaysThis("Good job sucking up to your instructor!");
            //     }
            //     else
            //     {
            //         MooseSaysThis("You will...oh, yes, you will...");
            //     }
            // }

        }

        static void GeorgeQuestion()
        {
            bool isTrue = MooseAsks("Are Oceania, Eurosia, and Eastasia real?");
            if (isTrue)
            {
                MooseSaysThis("Really? It seems very unlikely.  Have you read 1984? ");
            }
            else
            {
                MooseSaysThis("I  K N E W  I T !!! ");
            }
        }

        static void EnthusiasticQuestion()
        {
            bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
            if (isEnthusiastic)
            {
                MooseSaysThis("Yay!");
            }
            else
            {
                MooseSaysThis("You should try it!");
            }
        }

        static void LoveCSharpQuestion()
        {
            bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
            if (doesLoveCSharp)
            {
                MooseSaysThis("Good job sucking up to your instructor!");
            }
            else
            {
                MooseSaysThis("You will...oh, yes, you will...");
            }
        }

        static void SecretQuestion()
        {
            bool isEverythingFine = MooseAsks("Do you want to know a secret?");
            if (isEverythingFine)
            {
                MooseSaysThis("ME TOO!!!! I love secrets...tell me one!");
            }
            else
            {
                MooseSaysThis("Oh, no...secrets are the best, I love to share them!");
            }
        }

        static void MooseSaysThis(string message)
        {
            Console.WriteLine($"{message}");
        }
        static void MooseSays(string message1, string message2)
        {
            Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message1}
                      / `^`   `^` \   {message2}
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
            ");
        }

        static bool MooseAsks(string question)
        {
            Console.Write($"{question} (Y/N): ");
            string answer = Console.ReadLine().ToLower();

            while (answer != "y" && answer != "n")
            {
                Console.Write($"{question} (Y/N): ");
                answer = Console.ReadLine().ToLower();
            }

            if (answer == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
//    NOTE: We add an @ in front of the string to allow for a multi-line string.
//    NOTE: In C# we use the word "method" when referring to a function. We'll use the term method throughout the remainder of the exercise.
//line 15 creating a method/function 
//line 12 calling the function
// line 17 NOTE: We added the $ character to the front of the string to enable string interpolation.


