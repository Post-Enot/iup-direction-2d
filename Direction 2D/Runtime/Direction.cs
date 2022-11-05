using System;

namespace IUP_Toolkits.Direction2D
{
    [Flags]
    public enum Direction : byte
    {
        None = 0,
        Up = 1,
        Down = 2,
        Left = 4,
        Right = 8
    }
}
