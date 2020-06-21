using System;

namespace codexPopuli_Arkanoid.Modelo
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(string Message) : base(Message) { }
    }
}