using System;

namespace codexPopuli_Arkanoid.Modelo
{
    public class ExceededMaxCharactersException : Exception
    {
        public ExceededMaxCharactersException(string Message) : base(Message) { }

    }
}