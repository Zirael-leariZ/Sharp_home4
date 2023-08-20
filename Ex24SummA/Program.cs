// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReturnNumber(string two_digit)
{
    int i;
    int result = 1;

    int FirstDigit = int.Parse(two_digit[0].ToString());
    int SecondDigit = int.Parse(two_digit[1].ToString());

    for(i=0; i < SecondDigit; i++)
    {
        result = result * FirstDigit;
    }
    
    return result;
}

Console.WriteLine("Your Input: ");
string UserInput = Console.ReadLine();
int power = ReturnNumber(UserInput);
Console.WriteLine(power);





// int FillNumber(string message)
// {
//     Console.WriteLine($"Input: {message}");
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }