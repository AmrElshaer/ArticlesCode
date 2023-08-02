using BenchmarkDotNet.Running;
using StringInterpolation.Logging;

namespace TestRider {
    internal class Program {
        public static void Main(string[] args) {
            //BenchmarkRunner.Run<TestPerformance>();
            BenchmarkRunner.Run<TestLoggingWithoutAdapter>();
            BenchmarkRunner.Run<TestLoggingWithAdapter>();
        }
    }
}
