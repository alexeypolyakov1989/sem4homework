// Программа, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, -5, 0, -11 -> [1, 2, 5, 7, 19, -5, 0, -11]

int[] array = new int[8];
Random rand = new Random();
Console.Write("[" );
for    (int i=0;   i<array.Length; i++)
{
    array[i] = rand.Next(-99, 99);
    string number = Convert.ToString(array[i]);
    Console.Write(number+";");
}
Console.Write("]" );
