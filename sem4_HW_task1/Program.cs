// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int number; // - число
int rank; // - степень
int result; 

int NumberToRank(int number)
{
if (rank < 1)
    return -1;

int result = (int) Math.Pow(number, rank);
return result;
}

Console.WriteLine("Программа возведения числа в степень");
Console.WriteLine("Пожалуйста, введиде число");

while (!int.TryParse(Console.ReadLine(), out number))
{
     Console.WriteLine("ошибка ввода числа, попробуйте еще раз");
}

Console.WriteLine("Пожалуйста введите натуральную степень");
while (!int.TryParse(Console.ReadLine(), out rank))
{
    Console.WriteLine("ошибка ввода числа, попробуйте еще раз");
}

if (rank < 1)
{
    Console.WriteLine("Число должно быть натуральным");
    return;
}

result = NumberToRank(number);
Console.WriteLine($"Рузультат: {result}");