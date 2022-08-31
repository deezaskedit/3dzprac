// 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


void Cube(int number)
{
    int current = 1;
    while(current <= number)
    {
        Console.Write(Math.Pow(current, 3) + " ");
        current ++;
    }
}
Console.Write("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Cube(num);
