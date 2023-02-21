// Задача 29: Напишите программу, которая задаёт массив из элементов и выводит их на экран.


int [] NewArray (int size, int min, int max)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i]= new Random().Next(min, max + 1);
    }
    return array;

}

void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array [i] + " " );
    }
    Console.WriteLine();
}
Console.Write("imput count of elements of array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

Console.Write("imput minimal possible value on array: ");
int minArray = Convert.ToInt32(Console.ReadLine());

Console.Write("imput maximal possible value on array: ");
int maxArray = Convert.ToInt32(Console.ReadLine());

int [] createdArray = NewArray (sizeArray, minArray,maxArray);
ShowArray (createdArray);











