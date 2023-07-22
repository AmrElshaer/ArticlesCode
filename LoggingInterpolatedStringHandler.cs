// using System.Collections.Generic;
// using System.Runtime.CompilerServices;
// using JetBrains.Annotations;
//
// namespace TestRider;
//
// public ref struct LoggingInterpolatedStringHandler
// {
//     private DefaultInterpolatedStringHandler _defaultHandler;
//
//     [ItemCanBeNull]
//     public List<object> Parameters { get; } = new();
//
//     public LoggingInterpolatedStringHandler(int literalLength, int formattedCount)
//     {
//         _defaultHandler = new DefaultInterpolatedStringHandler(literalLength, formattedCount);
//     }
//
//     public override string ToString()
//     {
//         return _defaultHandler.ToString();
//     }
//
//     public string ToStringAndClear()
//     {
//         return _defaultHandler.ToStringAndClear();
//     }
//
//     public void AppendLiteral(string s)
//     {
//         _defaultHandler.AppendLiteral(s);
//     }
//
//     public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string paramName = "")
//     {
//         _defaultHandler.AppendFormatted("{" + value + "}");
//         Parameters.Add(value);
//     }
// }


