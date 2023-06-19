// Задача 13
Console.Clear();
Console.Write("Введите минимум трехзначное число: ");
string userInput = Console.ReadLine();
int length = userInput.Length;
int number = int.Parse(userInput);

if(length == 3)
{
    
    int a3 = number % 10;
    Console.WriteLine($"Третья цифра числа {number} -> {a3}");
} 
if(length == 4)
{
    int a3 = (number / 10) % 10;
    Console.WriteLine($"Третья цифра числа {number} -> {a3}");
} 
if(length == 5)
{
    int a3 = (number / 100) % 10;
    Console.WriteLine($"Третья цифра числа {number} -> {a3}");
} 
if(length == 6)
{
    int a3 = (number / 1000) % 10;
    Console.WriteLine($"Третья цифра числа {number} -> {a3}");
} 
if(length == 7)
{
    int a3 = (number / 10000) % 10;
    Console.WriteLine($"Третья цифра числа {number} -> {a3}");
} 
if(length == 8)
{
    int a3 = (number / 100000) % 10;
    Console.WriteLine($"Третья цифра числа {number} -> {a3}");
} 
if(length < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
