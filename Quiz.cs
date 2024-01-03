public class Quiz
{
    private List<Question> questions;
    private int currentQuestionIndex;

    public Quiz(List<Question> questions)
    {
        this.questions = questions;
        this.currentQuestionIndex = 0;
    }

    public void DisplayCurrentQuestion()
    {
        Question currentQuestion = questions[currentQuestionIndex];

        Console.WriteLine(currentQuestion.Prompt);

        for (int i = 0; i < currentQuestion.Options.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {currentQuestion.Options[i]}");
        }
    }

    public bool CheckAnswer(int userAnswer)
    {
        Question currentQuestion = questions[currentQuestionIndex];

        if (userAnswer - 1 < 0 || userAnswer - 1 >= currentQuestion.Options.Length)
        {
            throw new IndexOutOfRangeException("Invalid answer choice.");
        }
        return currentQuestion.Options[userAnswer - 1] == currentQuestion.CorrectOption;
    }

    public void MoveToNextQuestion()
    {
        currentQuestionIndex++;
    }

    public bool HasMoreQuestions()
    {
        return currentQuestionIndex < questions.Count;
    }
       public int CurrentQuestionIndex => currentQuestionIndex;
}