// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

 
static void Array(int[] input)
{
    Console.Write("[");
    for (int i = 0; i < input.Length; i++)
    {
        Console.Write(input[i]);
        if (i < input.Length - 1) // Check if it's not the last element
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

static void FullFill(int[] console)
{
    for(int i = 0; i < console.Length; i++)
    {
        console[i]= new Random().Next(1,30);
    }
}

int[] array = new int[8];
FullFill(array);
Array(array);
Console.WriteLine(array);