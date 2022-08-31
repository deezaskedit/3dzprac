// 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrome(int number)
{
    int inverse = 0;
    int newnumber = number;
    while(number > 0)
    {
        int rem = number % 10;
        inverse = inverse * 10 + rem;
        number = number/10;
    }
    if(newnumber == inverse) Console.WriteLine($"{inverse} - Число является палиндромом");
    else Console.WriteLine($"{inverse} - Число не является палиндромом");
}
Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrome(num);