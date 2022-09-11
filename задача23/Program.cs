// напишите программу, которая пртмимает на вход число N
// и выдает таблицу кубов чисел от 1 до N
int start = 1;
int end = Convert.ToInt32(Console.ReadLine());
while(start<=end)
{
    Console.WriteLine(start*start*start);
    start++;
}

