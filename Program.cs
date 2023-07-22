using System;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace TestRider
{


    public class Extentions
    {
        public static void ItIsTrue
        (
            bool condition,
            [InterpolatedStringHandlerArgument("condition")]
            ref EnsureInterpolatedStringHandler message,
            [CallerArgumentExpression("condition")]
            string paramName = ""
        )
        {
            if (!condition)
            {
                throw new ArgumentException(message.ToString(), paramName);
            }
        }
    }

    public record struct User(string Name, string Address, int Number, int Age)
    {
        public string GetUserMessage(User user)
        {
            return $"User Name is user {user.Name} and address is {user.Address} and number is {user.Number} and Age is {user.Age}";
        }

        public void Display(string message)
        {
            Console.WriteLine(message);
        }

        public int ValidateAge()
        {

            Extentions.ItIsTrue(Age > 18, $"User age is {Age} but must be greater than 18");
            return Age;
        }
    }

    [MemoryDiagnoser]
    public class TestPerformance
    {
        [Benchmark]
        public void Test()
        {
            var user = new User("John", "London", 1, 20);

            user.ValidateAge();

            var message = user.GetUserMessage(user);
            user.Display(message);
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<TestPerformance>();
        }
    }
}
