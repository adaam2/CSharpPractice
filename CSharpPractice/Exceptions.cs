using System;

namespace CSharpPractice
{
    public class ExceptionTester
    {
        public ExceptionTester()
        {
            for (int i = 0; i < 10000; i++)
            {
                if (i > 50)
                {
                    throw new CustomException("number is too much");
                }
            }
        }
    }
    [Serializable]
    class CustomException : Exception
    {
        public CustomException(string message)
        {
            Console.WriteLine(message);
            
        }
        public CustomException(string message, Exception innerException) : base(message, innerException)
        {
            Console.WriteLine(message + innerException);
        }
    }
}
