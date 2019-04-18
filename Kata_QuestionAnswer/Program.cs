using System;
using System.Text;

using Kata.QuestionAnswer;

namespace KataQuestionAnswer
{
    class Program
    {
        static void Main(string[] args)
        {

            AskQuestionWithIntAnswer();
            AskQuestionWithDateTimeAnswer();
        }

        static void AskQuestionWithIntAnswer()
        {
            // Read data from database
            string questionText1 = "How old are you?";
            Console.WriteLine(questionText1);

            // Get user's answer from the web
            byte[] answerFromTheWeb1 = Encoding.UTF8.GetBytes(Console.ReadLine());

            // Deserialize rules from the database
            var rules = new IRule<int>[]
            {
                    new IntGreaterRule { ValueToCompare = 0 },
                    new IntLessRule { ValueToCompare = 150 }
            };

            // Based on deserialized data construct an question object
            var question1 = new Question<int>("How old are you?", rules);

            Console.WriteLine($"Q1: The result after checking rules: {question1.Check(answerFromTheWeb1)}");
        }

        static void AskQuestionWithDateTimeAnswer()
        {
            // Read data from database
            string questionText2 = "When were you born?";
            Console.WriteLine(questionText2);

            // Get user's answer from the web
            byte[] answerFromTheWeb2 = Encoding.UTF8.GetBytes(Console.ReadLine());

            // Deserialize rules from the database
            var newRules = new IRule<DateTime>[]
            {
                new DateTimeEarlierThanRule { ValueToCompare = DateTime.Now.AddYears(-18) }
            };

            // Based on deserialized data construct an question object
            var question2 = new Question<DateTime>("How old are you?", newRules);

            Console.WriteLine($"Q2: The result after checking rules: {question2.Check(answerFromTheWeb2)}");
        }
    }
}
