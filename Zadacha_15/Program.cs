
Console.WriteLine("Давайте проверим является ли день выходным! Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7)
{
   Console.WriteLine("Ошибка");
}

if(number >=1 && number <= 5)
{
   Console.WriteLine("Нет");
}
if(number == 6  | number == 7)
{
   Console.WriteLine("Да");
}
