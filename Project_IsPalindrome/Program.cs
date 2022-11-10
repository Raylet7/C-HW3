// Программа, принимающая целое число любой разрядности 
// и проверяющая, является ли оно палиндромом
void Result(int number)
{
    int oldValue = number;
    int newValue = 0;
    while (number > 0)
    {
        int temp = number % 10;
        newValue = newValue * 10 + temp;
        number = number / 10;
    }
    if (newValue == oldValue)
    {
        Console.WriteLine("Да, число является палиндромом");
    }    
    else
    {
        Console.WriteLine("Нет, число не является палиндромом");
    }
}
Console.WriteLine("Программа проверки палиндромности числа");
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if (number < 0)
{
    number = number * -1;
}
Result(number);