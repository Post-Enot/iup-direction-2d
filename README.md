Unity-пакет, содержащий класс-перечисление для репрезентации направления в двухмерном пространстве, а также методы расширения, упрощающие работу с ним.

# Как использовать
Перечисление **[IUP.Toolkits.Direction2D.Direction](https://github.com/Post-Enot/direction-2d/blob/main/Direction%202D/Runtime/Direction.cs#L9)** содержит 9 флагов (с учётом 0 флага), соответственно:

| Флаг                    | Bin          | Dex | Vector2Int | Направление            |
|-------------------------|--------------|-----|------------|------------------------|
| **Direction.None**      | 0000         | 0   | (0, 0)     | Отсутствие направления |
| **Direction.Up**        | 000**1**     | 1   | (0, 1)     | Вверх                  |
| **Direction.Down**      | 00**1**0     | 2   | (0, -1)    | Вниз                   |
| **Direction.Left**      | 0**1**00     | 4   | (-1, 0)    | Влево                  |
| **Direction.Right**     | **1**000     | 8   | (1, 0)     | Вправо                 |
| **Direction.UpLeft**    | 0**1**0**1** | 5   | (-1, 1)    | Вверх-влево            |
| **Direction.UpRight**   | **1**00**1** | 9   | (1, 1)     | Вверх-вправо           |
| **Direction.DownLeft**  | 0**11**0     | 6   | (-1, -1)   | Вниз-влево             |
| **Direction.DownRight** | **11**00     | 12  | (1, -1)    | Вниз-вправо            |

При необходимости репрезентации направления необходимо использовать данный класс, а также его методы расширения.

## Наборы флагов без смысла

Не у всех сочетаний флагов имеется смысл: например, 
**1111**. Для проверки, имеет ли значение типа Direction смысл, нужно использовать метод расширения
**[IUP.Toolkits.Direction2D.Direction.IsValueMakeSence()](https://github.com/Post-Enot/direction-2d/blob/main/Direction%202D/Runtime/DirectionExtension.cs#L103)**: в 
вслучае, если значение имеет смысл, будет возвращено true, иначе false.

**Пример:**

```c#
Direction direction = Direction.Up | Direction.Down;
bool isValueMakeSence = direction.IsValueMakeSence();
Debug.Log(isValueMakeSence); // Output: false.
```

## Исключения

Для исключений, связанных с не имеющими смысла значениемями перечисления направления необходимо использовать исключение 
**[IUP.Toolkits.Direction2D.DirectionValueMeaninglessException](https://github.com/Post-Enot/direction-2d/blob/main/Direction%202D/Runtime/DirectionValueMeaninglessException.cs#L8)**.

## Перебор наборов направлений

Часто в прикладных задачах необходимо перебрать в цикле все направления по определённому критерию: например, только прямые или только диагональные направления. 
Класс **[IUP.Toolkits.Direction2D.DirectionUtility](https://github.com/Post-Enot/direction-2d/blob/main/Direction%202D/Runtime/DirectionUtility.cs#L8)** предоставляет 
статические методы, возвращающие перебираемые наборы всех, прямых и диагональных направлений. С помощью флага **includeZeroDirection** возможно задать, должен ли 
набор содержать отсутствие направления.

**Пример:**

```c#
foreach (Direction direction in DirectionUtility.DirectDirections(includeZeroDirection: true))
{
    Debug.Log(direction);
}
/* Output:
   Direction.None
   Direction.Up
   Direction.Down
   Direction.Left
   Direction.Right
*/
```

## Преобразование направления в вектор

Преобразование типа перечисления направления в реализованный в Unity3D формат вектора возможно с помощью методов расширения:  

**[IUP.Toolkits.Direction2D.Direction.ToVector2()](https://github.com/Post-Enot/direction-2d/blob/main/Direction%202D/Runtime/DirectionExtension.cs#L16)** - преобразовывает в структуру **UnityEngine.Vector2**.  
**[IUP.Toolkits.Direction2D.Direction.ToVector2Int()](https://github.com/Post-Enot/direction-2d/blob/main/Direction%202D/Runtime/DirectionExtension.cs#L38)** - преобразовывает в структуру **UnityEngine.Vector2Int**.  
**[IUP.Toolkits.Direction2D.Direction.ToVector3()](https://github.com/Post-Enot/direction-2d/blob/main/Direction%202D/Runtime/DirectionExtension.cs#L60)** - преобразовывает в структуру **UnityEngine.Vector3**.  
**[IUP.Toolkits.Direction2D.Direction.ToVector3Int()](https://github.com/Post-Enot/direction-2d/blob/main/Direction%202D/Runtime/DirectionExtension.cs#L82)** - преобразовывает в структуру **UnityEngine.Vector3Int**.

**Пример:**

```c#
Direction direction = Direction.UpLeft;
Debug.Log(direction.ToVector2()); // Output: (-1.0f, 1.0f)
Debug.Log(direction.ToVector2Int()); // Output: (-1, 1)
Debug.Log(direction.ToVector3()); // Output: (-1.0f, 1.0f, 0.0f)
Debug.Log(direction.ToVector3Int()); // Output: (-1, 1, 0)
```

При попытке преобразовать к структуре вектора значение перечисления направления, не имеющего смысл, будет вызвано исключение 
**[IUP.Toolkits.Direction2D.DirectionValueMeaninglessException](https://github.com/Post-Enot/direction-2d/blob/main/Direction%202D/Runtime/DirectionValueMeaninglessException.cs#L8)**.

**Пример:**

```c#
Direction direction = Direction.Up | Direction.Down;
Debug.Log(direction.ToVector2()); // Будет вызвано исключение DirectionValueMeaninglessException
```

# Принятые решения и пояснения к ним
 * Тип **byte** для перечисления **[IUP.Toolkits.Direction2D.Direction](https://github.com/Post-Enot/direction-2d/blob/main/Direction%202D/Runtime/Direction.cs#L9)** выбран с точки зрения оптимизации.

# Контакты
По всем вопросам писать в Telegram: https://t.me/ProcyonNihil
