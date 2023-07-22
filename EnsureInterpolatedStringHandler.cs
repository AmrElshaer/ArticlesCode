using System.Runtime.CompilerServices;

namespace TestRider;

[InterpolatedStringHandler]
public ref struct EnsureInterpolatedStringHandler
{
    private DefaultInterpolatedStringHandler _defaultHandler;

    public EnsureInterpolatedStringHandler
    (
        int literalLength,
        int formattedCount,
        bool condition,
        out bool shouldAppend
    )
    {
        if (condition)
        {
            _defaultHandler = default;
            shouldAppend = false;
        }

        _defaultHandler = new DefaultInterpolatedStringHandler(literalLength, formattedCount);
        shouldAppend = true;
    }

    public override string ToString()
    {
        return _defaultHandler.ToString();
    }

    public string ToStringAndClear()
    {
        return _defaultHandler.ToStringAndClear();
    }

    public void AppendLiteral(string s)
    {
        _defaultHandler.AppendLiteral(s);
    }

    public void AppendFormatted<T>(T value)
    {
        _defaultHandler.AppendFormatted(value);
    }
}


