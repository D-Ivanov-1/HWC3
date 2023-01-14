//Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// * 3 -> 1, 8, 27
// * 5 -> 1, 8, 27, 64, 125
Console.Clear();
string str;
int N;
Console.WriteLine("Введите число: ");
str = Console.ReadLine();
N = Convert.ToInt32(str);
Console.Clear();
int result = 0;
for (int i = 1; i <= N; i++)
{
    result = i*i*i;
    
    Console.WriteLine(result);

}