using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.Logging;
using TestRider;

namespace StringInterpolation.Logging;

[MemoryDiagnoser]
public class TestLoggingWithoutAdapter {
    private readonly ILoggerFactory _loggerFactory = LoggerFactory.Create(builder =>
        builder.AddConsole().SetMinimumLevel(LogLevel.Information));

    private readonly ILogger<TestLoggingWithoutAdapter> _logger;

    public TestLoggingWithoutAdapter() {
        _logger = new Logger<TestLoggingWithoutAdapter>(_loggerFactory);
    }

    [Benchmark]
    public void TestWithoutAdapter() {
        var user = new User("John", "London", 1, 20);
        _logger.LogInformation("User age is {Age} but must be greater than 18", user.Age);
    }
}
