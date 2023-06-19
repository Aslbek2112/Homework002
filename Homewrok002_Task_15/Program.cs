// Задача 15.
Console.Clear();
Console.Write("Введите цифру от 1 по 7: ");
string day_of_weeek = Console.ReadLine()?? "";
int number;

if (int.TryParse(day_of_weeek, out number))
{
    if(number >=1 && number <=7)
    {
        if(number <=5)
        {
            Console.WriteLine($"Нет {number} день недели рабочий");
        }
        if (number > 5 && number <8)
        {
            Console.WriteLine($"Да {number} день недели выходной");
        }
    }
    else
    {
        Console.Write("Пожалуйста введите цифру от 1 по 7.");
    }
}
else
{
     Console.WriteLine("Ошибка! Вы ввели не число. Попробуй еще раз.");
}

