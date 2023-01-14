
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//* 14212 -> нет
//* 12821 -> да
//* 23432 -> да
Console.Clear();
string str;
int Val1;
Console.WriteLine("Введите число ");
str = Console.ReadLine();
Val1 = Convert.ToInt32(str);
int Val2 = 0;
int Val3 = Val1;
while (Val1 != 0)
{
    int Val4 =Val1 % 10;
    Val1 = Val1 / 10;
    Val2 = Val2 *10 + Val4;
}
if (Val3 == Val2)
Console.WriteLine("Число является полиндромом");
else
{
    System.Console.WriteLine("Число не полиндром");

}