Console.WriteLine("Введите количество чисел, которые хотите ввести: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Количество положительных чисел = " + Sum());

int Sum()
{
    int sum = 0;
    for(int i = 1; i <= M ; i++)
    {
        Console.WriteLine($"Введите {i}-е число: ");
        if (int.Parse(Console.ReadLine()) >= 0) sum++;        
    }
    return sum;
}
