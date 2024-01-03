
namespace ConsoleQuiz
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Capital Cities Quiz!");
            Console.WriteLine("Brought to you by @ChrisMitchelll");
            Console.WriteLine("Press any key to start...");
            Console.ReadKey(true);

            Console.Clear();
            Console.WriteLine("Choose a mode:");
            Console.WriteLine("1. Basic Mode (5 random questions)");
            Console.WriteLine("2. Full Mode (all questions)");

            int modeChoice;
            while (true)
            {
                Console.Write("Enter your choice (1 or 2): ");
                if (int.TryParse(Console.ReadLine(), out modeChoice) && (modeChoice == 1 || modeChoice == 2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                }
            }

            Console.Clear();

            List<Question> questions;

            if (modeChoice == 1)
            {
                questions = GenerateBasicModeQuestions();
            }
            else
            {
                questions = GenerateFullModeQuestions();
            }

            Quiz quiz = new Quiz(questions);

            int correctAnswers = 0;

            while (quiz.HasMoreQuestions())
            {
                quiz.DisplayCurrentQuestion();

                while (true)
                {
                    try
                    {
                        Console.Write("Enter your answer (a number between 1 and 4):");
                        int userAnswer;

                        while (true)
                        {
                            string input = Console.ReadLine();

                            if (input != null && int.TryParse(input, out userAnswer) && (userAnswer >= 1 && userAnswer <= 4))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid answer. Please choose a number between 1 and 4.");
                            }
                        }


                        if (userAnswer < 1 || userAnswer > 4)
                        {
                            Console.WriteLine("Invalid answer. Please enter a number between 1 and 4.");
                            continue;
                        }

                        if (quiz.CheckAnswer(userAnswer))
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("Correct!\n");
                            correctAnswers++;
                        }
                        else
                        {
                            Question currentQuestion = questions[quiz.CurrentQuestionIndex];
                            Console.WriteLine("Incorrect. The correct answer is: " + currentQuestion.CorrectOption + "\n");
                        }

                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 4:");
                    }
                }

                quiz.MoveToNextQuestion();
            }

            Console.WriteLine("\nQuiz completed!\nYour final score is: " + correctAnswers + " out of " + questions.Count);

            Console.WriteLine("\nWould you like to retake the quiz? (y/n)");
            if (Console.ReadLine().ToLower() == "y")
            {
                Console.Clear();
                Main(); // Restart the quiz
                return;
            }

            Console.WriteLine("\n@ChrisMitchelll thanks you for playing");
            if (Console.ReadLine().ToLower() == "y")
            {
                Console.Clear();
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(); // Wait for a key press
            Environment.Exit(0); // Close the console window

        }

        static List<Question> GenerateBasicModeQuestions()
        {
            List<Question> allQuestions = Questions.GetQuestionsList();

            // Shuffle the questions in-place for variety
            Random random = new Random();
            for (int i = allQuestions.Count - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                Question temp = allQuestions[i];
                allQuestions[i] = allQuestions[j];
                allQuestions[j] = temp;
            }

            List<Question> basicQuestions = allQuestions.Take(5).ToList();

            return basicQuestions;
        }

        static List<Question> GenerateFullModeQuestions()
        {
            return Questions.GetQuestionsList();
        }
    }

}
