
        int[] numbers = { 1, 4, 3, 9, 12, 7, 6, 15, 8 };
        int sum = 0;

        Console.WriteLine("Исходный массив чисел:");
        PrintArray(numbers);

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 3 == 0)
            {
                sum += numbers[i];
            }
        }

        Console.WriteLine("Сумма всех чисел, кратных 3: " + sum);

    static void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}