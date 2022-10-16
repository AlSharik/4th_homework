//Задача *: Напишите программу, которая из массива случайных чисел. Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). Постарайтесь сделать одним циклом
//[1, 3, 5, 6, 6, 4] -> 5

int Prompt()
{
    Console.WriteLine("Write number >");
    string inputString = Console.ReadLine();
    int value = Convert.ToInt32(inputString);
    return value;
}
int length = Prompt();

int[] arr = new int [length];

for(int i = 0; i < length; i++)
{
    arr[i] = Prompt();
}
int max = arr[0];
int secondmax = arr[1];
int tmp = -1;
for(int i = 1; i < length; i++)
{
    if(arr[i] > max)
    {
        secondmax = max;
        max = arr[i];
    }
    else
    {
        if(arr[i] > secondmax)
        {
            secondmax = arr[i];
        }
    }
    if(arr[i] != max && arr[i] > tmp)
    {
        tmp = arr[i];
    }
}
if( max == secondmax)
{
    if(tmp == -1)
    {
        System.Console.WriteLine("Нет второго максимального");
    }
    else
    {
        System.Console.WriteLine(tmp);
    }
}
else
{
    System.Console.WriteLine(secondmax);
}