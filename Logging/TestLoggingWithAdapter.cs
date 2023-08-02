using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.Logging;
using TestRider;
using TestRider.Logging;

namespace StringInterpolation.Logging;

[MemoryDiagnoser]
public class TestLoggingWithAdapter {
    private readonly ILoggerFactory _loggerFactory = LoggerFactory.Create(builder =>
        builder.AddConsole().SetMinimumLevel(LogLevel.Information));

    private readonly ILoggerAdapter<TestLoggingWithAdapter> _logger;

    public TestLoggingWithAdapter() {
        _logger = new LoggerAdapter<TestLoggingWithAdapter>(new Logger<TestLoggingWithAdapter>(_loggerFactory));
    }

    [Benchmark]
    public void TestWithAdapter() {
        var user = new User("John", "London", 1, 20);
        _logger.LogInformation("User age is {Age} but must be greater than 18", user.Age);
    }
}
