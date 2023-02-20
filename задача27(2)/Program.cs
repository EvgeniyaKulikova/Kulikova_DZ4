//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void Sumofnumbers (int number)
{
    int remainder = 0;
    int result = 0;
    while ( number != 0)
    {
        remainder = number % 10;
        result = result + remainder;
        number = number / 10;
    }
  
    Console.WriteLine($"sum of number a {result}");
}

Console.Write("imput your number ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Sumofnumbers (userNumber);




