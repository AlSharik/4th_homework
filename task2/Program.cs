// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Функция должна на вход принимать число, а выдавать сумму его цифр
//452 -> 11
//82 -> 10
//9012 -> 12

int Prompt()
{
    Console.WriteLine("Write number >");
    string inputString = Console.ReadLine();
    int value = Convert.ToInt32(inputString);
    return value;
}

int NumbersSumInt (int number)
{
    int result = 0;
    int index = 11;
    while(index > 0)
    {
        result+=number % 10;
        number/=10;
        index--;
    }
    return result;
}
int number = Prompt();
int total = NumbersSumInt(number);
System.Console.WriteLine($"Сумма цифр {total}");