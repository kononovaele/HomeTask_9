//
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.
//
// M = 1; N = 15 -> 120
// M = 4; N = 8  -> 30
//

// Получим массив целых чисел из консоли
// Возвращает массив целых чисел
int[] GetArrayFromConsole()
{
    Console.Write("\nInput two digits (M N) of integer, please: ");

    string? strInput = Console.ReadLine();
    if( String.IsNullOrEmpty(strInput) == true)
        strInput = "0";

    int[] array = strInput.Split().Select(int.Parse).ToArray();

    return array;
}

// Выполнить рекурсию
// Возвращает сумму чисел с digitFrom по digitTo
int Recursion(int digitFrom, int digitTo)
{
    if(digitFrom < digitTo) {
        digitFrom = digitFrom + Recursion(digitFrom + 1, digitTo);
    }

    return digitFrom;
}

void main()
{
    Console.WriteLine("\n ------- Task-66 -------");

    int[] arrayInput = GetArrayFromConsole();

    int M = arrayInput[0];
    int N = arrayInput[1];

    // Получимм сумму чисел с M по N
    int Sum = Recursion(M, N);
    Console.WriteLine($"\n M = {M}, N = {N}, Sum is: {Sum}\n");
}

main();


