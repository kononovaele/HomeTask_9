//
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии. Выведем двумя способами от N до 1 и от 1 до N
//
// N = 5 -> "5, 4, 3, 2, 1"
// N = 5 -> "1, 2, 3, 5, 5"
//
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// N = 8 -> "1, 2, 3, 4, 5, 6, 7, 8"
//

// Ввод данных. Проверка на пустую строку и NULL
// Возвращает введенное число - целое
int GetDigitFromConsole()
{
    Console.Write("\nInput one digit of integer, please: ");

    string? strInput = Console.ReadLine();
    if( String.IsNullOrEmpty(strInput) == true)
        strInput = "0";

    int N = Convert.ToInt32(strInput);

    return N;
}

// Рекурсивная функция. Печатает числа от 1 до N. В виде N, N - 1, N - 2... 3, 2, 1
// Возвращает сумму числе от 1 до N
int Recursion(int digit)
{
    if(digit >= 1) {
        if(digit == 1)
            Console.Write("{0,2}", digit);
        else
            Console.Write("{0,2}, ", digit);
        digit = digit + Recursion(digit - 1);
    }

    return digit;
}

// Рекурсивная функция. Печатает числа от 1 до N. В виде 1, 2, 3... N - 2, N - 1, N
// Возвращает сумму числе от 1 до N
int RecursionForward(int digit, int N)
{
    if(digit <= N) {
        if(digit == N)
            Console.Write("{0,2}", digit);
        else
            Console.Write("{0,2}, ", digit);
        digit = digit + RecursionForward(digit + 1, N);
    }

    return digit;
}

void main()
{
    Console.WriteLine("\n ------- Task-64 -------");

    // Получить число
    int N = GetDigitFromConsole();

    Console.Write("\n Back output    : ");
    // Печать чисел от 1 до N, в обратном порядке N, N - 1... 3, 2, 1
    Recursion(N);
    Console.Write("\n Forward output : ");
    // Печать чисел от 1 до N, в прямом порядке 1, 2, 3... N - 1, N
    RecursionForward(1, N);
    Console.WriteLine("\n");
}

main();

