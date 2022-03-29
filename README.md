# MathematicalParser
Парсер для математический вычислений, который позволит преобразовывать строки с математическими выражениями и вычислять их.

Пример использования:

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
