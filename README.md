# MathematicalParser
Парсер для математический вычислений, который позволит преобразовывать строки с математическими выражениями и вычислять их.

Пример использования:

```cs
var parser = new MathParser();
var expression = "x+y+2*z";
var parseResult = parser.TryParse(expression, "x", "y", "z");

if (parseResult.IsSuccessfulCreated)
{
    var x = 1;
    var y = 2;
    var z = 23;
    
    var result = parseResult.Expression.ComputeValue(x, y, z);
    //Вывод числового значения функции
    Console.WriteLine(result);
}
else
{
    Console.WriteLine(parseResult.ErrorMessage);
}
```

Подробная документация библиотеки:

https://docs.google.com/document/d/1TFiDlCP5zGI0uFyq_etCWrmAOlhUKp-hh_oB5cQFZH0/edit?usp=sharing
