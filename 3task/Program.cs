int number,result;

Console.WriteLine("Введите первое число");
number=Convert.ToInt32(Console.ReadLine());

result=number%2; // делим число на %2 - операция проверки деления без остатка, как правило используют для проверки на четность

if (result==0) // если результатом деления является 0, тогда четное, иначе нет
{
Console.WriteLine("Число четное ");
}
else
{
Console.WriteLine("Число не четное ");
}