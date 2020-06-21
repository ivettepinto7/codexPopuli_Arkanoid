using System;

namespace codexPopuli_Arkanoid.Modelo
{
    public class EmptyNicknameException :Exception 
    {
        public EmptyNicknameException(string Message) : base(Message) { }
    }
}