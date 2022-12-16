using System.Collections.Generic;

namespace IUP.Toolkits.Direction2D
{
    /// <summary>
    /// Класс, содержащий статические методы для упрощения работы с направлениями.
    /// </summary>
    public static class DirectionUtility
    {
        /// <summary>
        /// Метод для перебора всех направлений.
        /// </summary>
        /// <param name="includeZeroDirection">Необходимо ли включать в перебор отсутствие 
        /// направления?</param>
        /// <returns>Возвращает перебираемый набор всех направлений.</returns>
        public static IEnumerable<Direction> Directions(bool includeZeroDirection = false)
        {
            if (includeZeroDirection)
            {
                yield return Direction.None;
            }
            yield return Direction.Up;
            yield return Direction.Down;
            yield return Direction.Left;
            yield return Direction.Right;
            yield return Direction.UpLeft;
            yield return Direction.UpRight;
            yield return Direction.DownLeft;
            yield return Direction.DownRight;
        }

        /// <summary>
        /// Метод для перебора прямых направлений.
        /// </summary>
        /// <param name="includeZeroDirection">Необходимо ли включать в перебор отсутствие 
        /// направления?</param>
        /// <returns>Возвращает перебираемый набор прямых направлений.</returns>
        public static IEnumerable<Direction> DirectDirections(bool includeZeroDirection = false)
        {
            if (includeZeroDirection)
            {
                yield return Direction.None;
            }
            yield return Direction.Up;
            yield return Direction.Down;
            yield return Direction.Left;
            yield return Direction.Right;
        }

        /// <summary>
        /// Метод для перебора диагональных направлений.
        /// </summary>
        /// <param name="includeZeroDirection">Необходимо ли включать в перебор отсутствие 
        /// направления?</param>
        /// <returns>Возвращает перебираемый набор диагональных направлений.</returns>
        public static IEnumerable<Direction> DiagonalDirections(bool includeZeroDirection = false)
        {
            if (includeZeroDirection)
            {
                yield return Direction.None;
            }
            yield return Direction.UpLeft;
            yield return Direction.UpRight;
            yield return Direction.DownLeft;
            yield return Direction.DownRight;
        }
    }
}
