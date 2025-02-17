namespace Actividad_3
{
    using System;

    abstract class AbstractSample
    {
        private string message;

        public AbstractSample(string msg)
        {
            message = msg;
        }

        public abstract void PrintMessage();

        public virtual void InvertMessage()
        {
            char[] charArray = message.ToCharArray();
            Array.Reverse(charArray);
            message = new string(charArray);
            Console.WriteLine(message);
        }


        protected string GetMessage()
        {
            return message;
        }
    }

}