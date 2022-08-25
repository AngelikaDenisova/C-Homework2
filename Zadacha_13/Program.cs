// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number = new Random().Next(0, 1000000);
Console.WriteLine(number);

 if(number < 100)
 {
    Console.WriteLine("Третьего числа нет");
 }

if (number >= 100 && number < 1000)
{
    int result = number % 10;
    Console.WriteLine(result);
}

if (number >= 1000 && number < 10000)
{
    int result = number % 100 / 10;
    Console.WriteLine(result);
}

if (number >= 10000 && number < 100000)
{
    int result = number % 1000 / 100;
    Console.WriteLine(result);
}
if(number >=100000 && number < 1000000)
{
    int result = number / 1000 % 10;
    Console.WriteLine(result);
}
