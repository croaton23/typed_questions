using System;
using System.Text;

namespace KataQuestionAnswer
{
    class Serializer
    {
        public object Parse<T>(byte[] bytes)
        {
            if (typeof(T).Equals(typeof(int)))
                return int.Parse(Encoding.UTF8.GetString(bytes));

            if (typeof(T).Equals(typeof(DateTime)))
                return DateTime.Parse(Encoding.UTF8.GetString(bytes));

            if (typeof(T).Equals(typeof(string)))
                return Encoding.UTF8.GetString(bytes);

            throw new InvalidOperationException($"Can't cast byte blob to type {typeof(T)}");
        }
    }
}
