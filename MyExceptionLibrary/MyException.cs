using System;

namespace MyExceptionLibrary
{
    public class MyException : Exception
    {
        public string Value { get; }
        public MyException(string message)
        : base(message)
        { }

        public MyException(string message, string val)
        : base(message)
        {
            Value = val;
        }
    }
}
