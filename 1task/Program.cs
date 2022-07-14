int number1,number2;

Console.WriteLine("Введите первое число");
number1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
number2=Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
Console.WriteLine("Первое число " + number1 + " больше второго " + number2);
}
else
{
Console.WriteLine("Второе число " + number2 + " больше первого " + number1);
}