/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120  */
/*
Console.WriteLine("Введите число больше 1");
int number = int.Parse(Console.ReadLine());
int multiply = 1;
for (int i = 1; i <= number; i++)
{ 
    multiply = multiply * i;
}
Console.Write($"Произведение чисел от 1 до {number} равна {multiply}");

*/
int GetNumber(string message)
{
    int result = 0;
    while (true)
    { 
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или не корректное число. Повторите ввод.");
        }
    }
    return result;
}

void MultiplyNumber(int number)
{
   int multiply = 1;
   for (int i = 1; i <= number; i++)
    {
        multiply = multiply * i;
    }
    Console.WriteLine($"Произведение чисел от 1 до {number} равно {multiply}");
}

int number = GetNumber("Введите число больше 1: ");
MultiplyNumber(number);