using System;
using System.Collections.Generic;
using System.Text;

namespace KataQuestionAnswer
{
    interface IRule<T>
    {
        int QuestionId { get; }
        bool Applies(T answer);
    }

    abstract class Rule<T> : IRule<T>
    {
        public T ValueToCompare { get; set; }
        public int QuestionId { get; set; }
        public abstract bool Applies(T answer);
    }
}
