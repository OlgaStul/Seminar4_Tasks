/* Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36  */

Console.WriteLine("Введите число больше 1");
int number = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= number; i++)
{ 
    sum = sum + i;
}
Console.Write($"Сумма чисел от 1 до {number} равна {sum}");

/*
int GetNumber(string message)
{
int result = 0;

while(true)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out result) && result > 1)
{
break;
}
else
{
Console.WriteLine("Ввели не число. Повторите ввод");
}
}

return result;
}

int GetSumm(int number)
{
int sum = 0;

for (int i = 1; i <= number; i++)
{
sum += i;
}

return sum;
}

int number = GetNumber("Введите число больше 1");
int sum = GetSumm(number);
Console.WriteLine($"сумма чисел от 1 до {number} = {sum}");
*/
