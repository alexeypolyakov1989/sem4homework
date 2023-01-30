// программа, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int DigitsSum(int num)
{
    if (num < 1)
        num = Math.Abs(num); // чтобы работало для отрицательных чисел
    int sum = 0;
    while (num > 0)
    {
        int digit = num % 10; 
        sum = sum + digit;
        num /= 10;
    }
    return sum;
}

Console.WriteLine("Прога показывает сумму цифр введеного числа");
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = DigitsSum(num);
Console.WriteLine($"Рузультат: {result}");