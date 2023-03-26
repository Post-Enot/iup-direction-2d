using System;
using System.Collections.Generic;
using UnityEngine;

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

        public static Direction Vector2ToDirection(Vector2 vector)
        {
            if (vector == Vector2.zero)
            {
                return Direction.None;
            }
            vector.Normalize();
            float angleInDegrees = Vector2.SignedAngle(Vector2.right, vector);
            return angleInDegrees switch
            {
                (>= -22.5f) and (< 22.5f) => Direction.Right,
                (>= 22.5f) and (< 77.5f) => Direction.UpRight,
                (>= 77.5f) and (< 112.5f) => Direction.Up,
                (>= 112.5f) and (< 157.5f) => Direction.UpLeft,
                (>= 157.5f) or (< -157.5f) => Direction.Left,
                (>= -157.5f) and (< -112.5f) => Direction.DownLeft,
                (>= -112.5f) and (< -77.5f) => Direction.Down,
                (>= -77.5f) and (< -22.5f) => Direction.DownRight,
                _ => throw new ArgumentOutOfRangeException(nameof(angleInDegrees))
            }; ;
        }
    }
}
