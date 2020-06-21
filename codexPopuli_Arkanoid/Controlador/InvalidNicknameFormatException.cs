using System;

namespace codexPopuli_Arkanoid.Modelo
{
    public class InvalidNicknameFormatException : Exception
    {
        public InvalidNicknameFormatException(string Message) : base(Message) { }
    }
}