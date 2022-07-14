int number1,number2,number3,max;

Console.WriteLine("Введите первое число");
number1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число");
number2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число");
number3=Convert.ToInt32(Console.ReadLine());


// сначала проверяем два числа
// ПЕРВОЕ СРАВНЕНИЕ
if (number1 > number2)
{
    max=number1; // если число 1 больше 2 го, тогда устанавливаем max первым числом
}
else // иначе
{
    max=number2; // если число 2 больше 1 го, тогда устанавливаем max вторым числом
}
if (max<number3) // сравниваем число в max полученное при первом сравнении
{
    max=number3; // если 3 число оказаось больше числа при сравнении первых двух
}

Console.WriteLine("Максимальное число " + max);
