namespace ScienceLibrary.MathParser
{
    /// <summary> 
    /// Результат парсинга выражений
    /// </summary>
    public record MathTryParseResult
    {
        /// <summary>
        /// Флаг, возвращающий успешность парсинга выражения
        /// </summary>
        public bool IsSuccessfulCreated { get; init;}
        /// <summary>
        /// Выражение парсинга
        /// </summary>
        public IExpression Expression { get; init; }
        /// <summary>
        /// Строка ошибок, возникающей в ходе выполнения парсинга
        /// </summary>
        public string ErrorMessage { get; init; }
        /// <summary>
        /// Входная строка 
        /// </summary>
        public string InputString { get; init; }
    }
}