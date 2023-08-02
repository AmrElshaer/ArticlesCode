using System;

namespace TestRider;

public record struct User(string Name, string Address, int Number, int Age) {
    public string GetUserMessage(User user) {
        return $"User Name is user {user.Name} and address is {user.Address} and number is {user.Number} and Age is {user.Age}";
    }

    public void Display(string message) {
        Console.WriteLine(message);
    }

    public int ValidateAge() {
        Extentions.ItIsTrue(Age > 18, $"User age is {Age} but must be greater than 18");

        return Age;
    }
}
