using System;

namespace TestApplication.Exceptions
{
    public abstract class AppException : Exception
    {
        public abstract string code { get; }

        protected AppException(string msg): base(msg) 
        {
        }
    }
}