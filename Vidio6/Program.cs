// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, Alfa!");

string firstFriend = "Maria";

firstFriend = firstFriend.Trim();

string secondFriend = "Scott";

string friends = $"My friends are {firstFriend} and {secondFriend.Trim()}";

//Console.WriteLine(friends);
// friends = friends.Replace("Scott", "Pants");
//Console.WriteLine(friends.Contains("Scott"));

//Console.WriteLine(friends.ToUpper());
//Console.WriteLine(friends.Length);

//Console.WriteLine(friends.StartsWith("Sco"));
//Console.WriteLine(friends.StartsWith("My  "));
Console.WriteLine(friends.StartsWith("My "));