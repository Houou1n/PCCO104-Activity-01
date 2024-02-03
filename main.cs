using System;

class Program {
  public static void Main (string[] args) {
    string firstName = "BIOT";
    string lastName = "KA";
    string greetings = "hahahhaahh";
    int age = 17;
    int sum = 6 + 9;
    int difference = 8 - 3;
    Console.WriteLine ($"Hello {firstName} {lastName} Age: {age}");
    Console.WriteLine ($"Hello " + firstName + " " + lastName + " " + age + " " + greetings);
    Console.WriteLine ("Sum: " + sum);
    Console.WriteLine ("Difference: " + difference);
  }
}