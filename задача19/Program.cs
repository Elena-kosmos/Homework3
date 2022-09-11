// написать программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом
Console.Write("Введите пятизначное число число: ");
int number = Convert.ToInt32(Console.ReadLine());
string Number = Convert.ToString(number);
if(Number[0]==Number[4]|| Number[1]==Number[3])
{
    Console.WriteLine("число палиндром");
}
else 
{
  Console.WriteLine("число не палндром");  
}
if(Number.Length>5)
{
    Console.WriteLine("error введите пятизначное число");
}


