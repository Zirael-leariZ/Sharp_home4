// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int AllSumm(string array)
{
    int result = 0; 
    
    for(int i = 0; i < array.Length; i++)
    {
        result += int.Parse(array[i].ToString()); 
    }

    return result;
}

Console.WriteLine("Your Input: ");
string UserInput = Console.ReadLine();
int power = AllSumm(UserInput);
Console.WriteLine(power);
