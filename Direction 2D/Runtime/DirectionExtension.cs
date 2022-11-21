using UnityEngine;

namespace IUP.Toolkits.Direction2D
{
    /// <summary>
    /// Класс, содержащий методы расширения для класса-перечисления, репрезентующего направление 
    /// в двухмерном пространстве.
    /// </summary>
    public static class DirectionExtension
    {
        /// <summary>
        /// Конвертирует значение направления в UnityEngine.Vector2.
        /// </summary>
        /// <returns>Возвращает значение направления, конвертированное в UnityEngine.Vector2.</returns>
        /// <exception cref="DirectionValueMeaninglessException"></exception>
        public static Vector2 ToVector2(this Direction direction)
        {
            return direction switch
            {
                Direction.None                      => Vector2.zero,
                Direction.Up                        => Vector2.up,
                Direction.Down                      => Vector2.down,
                Direction.Left                      => Vector2.left,
                Direction.Right                     => Vector2.right,
                Direction.Up | Direction.Left       => new Vector2(-1, 1),
                Direction.Up | Direction.Right      => new Vector2(1, 1),
                Direction.Down | Direction.Left     => new Vector2(-1, -1),
                Direction.Down | Direction.Right    => new Vector2(1, -1),
                _                                   => throw new DirectionValueMeaninglessException()
            };
        }

        /// <summary>
        /// Конвертирует значение направления в UnityEngine.Vector2Int.
        /// </summary>
        /// <returns>Возвращает значение направления, конвертированное в UnityEngine.Vector2Int.</returns>
        /// <exception cref="DirectionValueMeaninglessException"></exception>
        public static Vector2Int ToVector2Int(this Direction direction)
        {
            return direction switch
            {
                Direction.None                      => Vector2Int.zero,
                Direction.Up                        => Vector2Int.up,
                Direction.Down                      => Vector2Int.down,
                Direction.Left                      => Vector2Int.left,
                Direction.Right                     => Vector2Int.right,
                Direction.Up | Direction.Left       => new Vector2Int(-1, 1),
                Direction.Up | Direction.Right      => new Vector2Int(1, 1),
                Direction.Down | Direction.Left     => new Vector2Int(-1, -1),
                Direction.Down | Direction.Right    => new Vector2Int(1, -1),
                _                                   => throw new DirectionValueMeaninglessException()
            };
        }

        /// <summary>
        /// Конвертирует значение направления в UnityEngine.Vector3.
        /// </summary>
        /// <returns>Возвращает значение направления, конвертированное в UnityEngine.Vector3.</returns>
        /// <exception cref="DirectionValueMeaninglessException"></exception>
        public static Vector3 ToVector3(this Direction direction)
        {
            return direction switch
            {
                Direction.None                      => Vector2.zero,
                Direction.Up                        => Vector2.up,
                Direction.Down                      => Vector2.down,
                Direction.Left                      => Vector2.left,
                Direction.Right                     => Vector2.right,
                Direction.Up | Direction.Left       => new Vector2(-1, 1),
                Direction.Up | Direction.Right      => new Vector2(1, 1),
                Direction.Down | Direction.Left     => new Vector2(-1, -1),
                Direction.Down | Direction.Right    => new Vector2(1, -1),
                _                                   => throw new DirectionValueMeaninglessException()
            };
        }

        /// <summary>
        /// Конвертирует значение направления в UnityEngine.Vector3Int.
        /// </summary>
        /// <returns>Возвращает значение направления, конвертированное в UnityEngine.Vector3Int.</returns>
        /// <exception cref="DirectionValueMeaninglessException"></exception>
        public static Vector3Int ToVector3Int(this Direction direction)
        {
            return direction switch
            {
                Direction.None                      => Vector3Int.zero,
                Direction.Up                        => Vector3Int.up,
                Direction.Down                      => Vector3Int.down,
                Direction.Left                      => Vector3Int.left,
                Direction.Right                     => Vector3Int.right,
                Direction.Up | Direction.Left       => new Vector3Int(-1, 1),
                Direction.Up | Direction.Right      => new Vector3Int(1, 1),
                Direction.Down | Direction.Left     => new Vector3Int(-1, -1),
                Direction.Down | Direction.Right    => new Vector3Int(1, -1),
                _                                   => throw new DirectionValueMeaninglessException()
            };
        }

        /// <summary>
        /// Проверяет, имеет ли смысл значение направления (содержит ли оно взаимоисключающие флаги).
        /// </summary>
        /// <returns>Возвращает true, если значение имеет смысл; иначе false.</returns>
        public static bool IsValueMakeSence(this Direction direction)
        {
            return  direction == Direction.None ||
                    direction == Direction.Up ||
                    direction == Direction.Down ||
                    direction == Direction.Left ||
                    direction == Direction.Right ||
                    direction == (Direction.Up | Direction.Left) ||
                    direction == (Direction.Up | Direction.Right) ||
                    direction == (Direction.Down | Direction.Left) ||
                    direction == (Direction.Down | Direction.Right);
        }
    }
}
