using System;

namespace codexPopuli_Arkanoid.Modelo
{
    public class WrongKeyPressedException : Exception
    {
        public WrongKeyPressedException(string Message) : base(Message) { }
    }
}