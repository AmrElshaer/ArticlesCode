using System;
using System.Runtime.CompilerServices;

namespace TestRider;

public class Extentions {
    public static void ItIsTrue
    (
        bool condition,
        [InterpolatedStringHandlerArgument("condition")]
        ref EnsureInterpolatedStringHandler message,
        [CallerArgumentExpression("condition")]
        string paramName = ""
    ) {
        if (!condition) {
            throw new ArgumentException(message.ToString(), paramName);
        }
    }
}
