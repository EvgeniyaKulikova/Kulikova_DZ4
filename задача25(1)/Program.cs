//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void findDegree (int numberA, int numberB)
{
    int digree = 1;
    int current = 1;

    for (current = 1; current <= numberB; current++) 
    {
        digree = digree * numberA;
    }
    Console.WriteLine($"degree number a {digree}");
}
 
 Console.WriteLine("imput number A");
 int A = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("imput number B");
 int B = Convert.ToInt32(Console.ReadLine());

if (A > 0 &  B > 0)
{
   findDegree(A,B);  
}
if (A < 0)
 {
    Console.Write("imput number again");
 }
if (B < 0)
 {
    Console.Write("imput number again");
 }




