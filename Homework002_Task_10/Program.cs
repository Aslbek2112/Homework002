// Задача 10
Console.Clear();
Console.Write("Введите трехзначное число: ");
string userInput = Console.ReadLine();
int number = int.Parse(userInput);

int number1 = number / 10;
int number2 = number1 % 10;

Console.WriteLine($"{number} -> {number2}");
