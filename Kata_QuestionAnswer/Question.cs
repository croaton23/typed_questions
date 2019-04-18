using System.Collections.Generic;
using System.Linq;

using KataQuestionAnswer;

namespace Kata.QuestionAnswer
{
    class Question<T>
    {
        string _question;
        IEnumerable<IRule<T>> _rules;
        Serializer _serializer;

        public Question(string question, IEnumerable<IRule<T>> rules)
        {
            _question = question;
            _rules = rules;
            _serializer = new Serializer();
        }

        public bool Check(byte[] answerFromTheWeb)
        {
            return _rules.All(r => r.Applies((T)_serializer.Parse<T>(answerFromTheWeb)));
        }
    }
}
