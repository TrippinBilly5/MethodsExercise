using System.Runtime.CompilerServices;

Console.WriteLine("What is your name?");
string userName = Console.ReadLine();

Console.WriteLine("How old are you?");
string userAge = Console.ReadLine();

Console.WriteLine("What is a name for a dog?");
string userDogName = Console.ReadLine();

Console.WriteLine("What color is your dog?");
string userDogColor = Console.ReadLine();

Console.WriteLine($"There was a person named {userName} who was {userAge} years old.");
Console.WriteLine($"{userName} had a {userDogColor} dog named {userDogName}.");

Console.WriteLine("Give me a number");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Give me a number to add to the first number");
int num2 = int.Parse(Console.ReadLine());

int sum = Sum(num1, num2);
Console.WriteLine($"The sum is {sum}");

Console.WriteLine("Give me a number");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Give me a number to add to the first number");
num2 = int.Parse(Console.ReadLine());

int product = Multiply(num1, num2);
Console.WriteLine($"The product is {product}");

static int Sum(int num1, int num2)
{
    return num1 + num2;
}

static int Multiply(int num1, int num2)
{
    return num1 * num2;
}
