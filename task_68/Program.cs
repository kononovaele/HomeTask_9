//
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
//
// m = 1, n = 2 -> 4
// m = 0, n = 1 -> 2
// m = 0, n = 0 -> 1
// m = 2, n = 2 -> 7
//
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

// Вычислим функцию Аккермана
int A(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return A(m - 1, 1);
    else
      return A(m - 1, A(m, n - 1));
}

void main()
{
    Console.WriteLine("\n ------- Task-68 -------");

    // Получим массив целых чисел из консоли, m = array[0] и n = array[1]
    int[] arrayInput = GetArrayFromConsole();

    int m = arrayInput[0];
    int n = arrayInput[1];

    // Вычислим функцию Аккермана
    int akk = A(m, n);

    Console.Write($"m = {m}, n = {n} => A(m,n) = {akk}");
}

main();


