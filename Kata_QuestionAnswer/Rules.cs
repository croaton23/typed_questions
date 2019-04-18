using System;

namespace KataQuestionAnswer
{
    class IntGreaterRule : Rule<int>
    {
        public override bool Applies(int answer)
        {
            return answer > ValueToCompare;
        }
    }
    class IntLessRule : Rule<int>
    {
        public override bool Applies(int answer)
        {
            return answer < ValueToCompare;
        }
    }
    class IntEqualsRule : Rule<int>
    {
        public override bool Applies(int answer)
        {
            return answer == ValueToCompare;
        }
    }

    class DateTimeEarlierThanRule : Rule<DateTime>
    {
        public override bool Applies(DateTime answer)
        {
            return answer < ValueToCompare;
        }
    }
}
