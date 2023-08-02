using BenchmarkDotNet.Attributes;

namespace TestRider;

[MemoryDiagnoser]
public class TestPerformance {
    [Benchmark]
    public void Test() {
        var user = new User("John", "London", 1, 20);

        user.ValidateAge();
        var message = user.GetUserMessage(user);
        user.Display(message);
    }
}
