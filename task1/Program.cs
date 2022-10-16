//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B (и в нулевую степень). Использовать свои функции, не использовать Math.Pow
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Prompt()
{
    Console.WriteLine("Write number >");
    string inputString = Console.ReadLine();
    int value = Convert.ToInt32(inputString);
    return value;
}
int Pow(int number, int pow)
{
    int value = 1;
    while(pow > 0)
    {
        value *= number;
        pow--;
    }
    return value;
}
int number = Prompt();
int pow = Prompt();
int result = Pow( number, pow);
System.Console.WriteLine(result);