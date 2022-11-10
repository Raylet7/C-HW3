// Программа, принимающая пятизначное число 
// и проверяющая, является ли оно палиндромом
// 14212 -> нет
// 12821 -> да
// 23432 -> да
bool IsPalindrome(int firstDigit, int secondDigit, int forthDigit, int fifthDigit)
{
        return firstDigit == fifthDigit && secondDigit == forthDigit;
}
void Result(int number)
{
    if (number > 9999 && number < 100000)
    {
        int firstDigit = 0;
        int secondDigit = 0;
        int forthDigit = 0;
        int fifthDigit = 0;
        firstDigit = number / 10000;
        secondDigit = number / 1000 % 10;
        forthDigit = number / 10 % 10;
        fifthDigit = number % 10;
        if (IsPalindrome(firstDigit, secondDigit, forthDigit, fifthDigit))
        {
            Console.WriteLine("Да, число является палиндромом");
        }
        else      
        {
            Console.WriteLine("Нет, число не является палиндромом");
        }

    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
Console.WriteLine("Программа проверки палиндромности пятизначного числа");
Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
while (number < 0)
{
    number = number * -1;
}
Result(number);