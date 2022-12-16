Unity-пакет, содержащий класс-перечисление для репрезентации направления в двухмерном пространстве, а также методы расширения, упрощающие работу с ним.

## Как использовать
Перечисление **[IUP.Toolkits.Direction2D.Direction](https://github.com/Post-Enot/direction-2d/blob/main/Direction%202D/Runtime/Direction.cs#L9)** содержит 9 флагов (с учётом 0 флага), соответственно:

0000 - отсутствие направления; (0, 0) в векторном формате.  
000**1** - направление вверх; (0, 1) в векторном формате.  
00**1**0 - направление вниз; (0, -1) в векторном формате.  
0**1**00 - направление влево; (-1, 0) в векторном формате.  
**1**000 - направление вправо; (1, 0) в векторном формате.

0**1**0**1** - направление вверх-влево; (-1, 1) в векторном формате.  
**1**00**1** - направление вверх-вправо; (1, 1) в векторном формате.  
0**11**0 - направление вниз-влево; (-1, -1) в векторном формате.  
**11**00 - направление вниз-вправо; (1, -1) в векторном формате.

При необходимости репрезентации направления необходимо использовать данный класс, а также его методы расширения.

## Наборы флагов без смысла

Не у всех сочетаний флагов имеется смысл: например, 
**1111**. Для проверки, имеет ли значение типа Direction смысл, нужно использовать метод расширения
**[IUP.Toolkits.Direction2D.Direction.IsValueMakeSence()](https://github.com/Post-Enot/direction-2d/blob/main/Direction%202D/Runtime/DirectionExtension.cs#L103)**: в 
вслучае, если значение имеет смысл, будет возвращено true, иначе false.

## Исключения

Для исключений, связанных с не имеющими смысла значениемями перечисления направления необходимо использовать исключение 
**[IUP.Toolkits.Direction2D.DirectionValueMeaninglessException](https://github.com/Post-Enot/direction-2d/blob/main/Direction%202D/Runtime/DirectionValueMeaninglessException.cs#L8)**.

## Перебор наборов направлений

Часто в прикладных задачах необходимо перебрать в цикле все направления по определённому критерию: например, только прямые или только диагональные направления. 
Класс [IUP.Toolkits.Direction2D.DirectionUtility](https://github.com/Post-Enot/direction-2d/blob/main/Direction%202D/Runtime/DirectionUtility.cs#L8) предоставляет 
статические методы, возвращающие перебираемые наборы всех, прямых и диагональных направлений. С помощью флага **includeZeroDirection** возможно задать, должен ли 
набор содержать отсутствие направления.

## Преобразование направления в вектор

Преобразование типа перечисления направления в реализованный в Unity3D формат вектора возможно с помощью методов расширения:  

**[IUP.Toolkits.Direction2D.Direction.ToVector2()](https://github.com/Post-Enot/direction-2d/blob/main/Direction%202D/Runtime/DirectionExtension.cs#L16)** - преобразовывает в структуру **UnityEngine.Vector2**.  
**[IUP.Toolkits.Direction2D.Direction.ToVector2Int()](https://github.com/Post-Enot/direction-2d/blob/main/Direction%202D/Runtime/DirectionExtension.cs#L38)** - преобразовывает в структуру **UnityEngine.Vector2Int**.  
**[IUP.Toolkits.Direction2D.Direction.ToVector3()](https://github.com/Post-Enot/direction-2d/blob/main/Direction%202D/Runtime/DirectionExtension.cs#L60)** - преобразовывает в структуру **UnityEngine.Vector3**.  
**[IUP.Toolkits.Direction2D.Direction.ToVector3Int()](https://github.com/Post-Enot/direction-2d/blob/main/Direction%202D/Runtime/DirectionExtension.cs#L82)** - преобразовывает в структуру **UnityEngine.Vector3Int**.

При попытке преобразовать к структуре вектора значение перечисления направления, не имеющего смысл, будет вызвано исключение 
**[IUP.Toolkits.Direction2D.DirectionValueMeaninglessException](https://github.com/Post-Enot/direction-2d/blob/main/Direction%202D/Runtime/DirectionValueMeaninglessException.cs#L8)**.

## Принятые решения и пояснения к ним:
 * Тип **byte** перечисления **[IUP.Toolkits.Direction2D.Direction](https://github.com/Post-Enot/direction-2d/blob/main/Direction%202D/Runtime/Direction.cs#L9)** выбран с точки зрения оптимизации.
