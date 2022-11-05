using System;

namespace IUP_Toolkits.Direction2D
{
    /// <summary>
    /// Класс-исключение, сообщающее, что значение направления не имеет смысла (содержит взаимоисключающие флаги).
    /// </summary>
    public class DirectionValueMeaninglessException : Exception
    {
        private const string _meaninglessValueMessage = "Значение направления не имеет смысла, т.к. содержит " +
            "взаимоисключающие флаги.";

        public DirectionValueMeaninglessException(string message = _meaninglessValueMessage) : base(message) { }
    }
}
