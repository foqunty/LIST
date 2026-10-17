Console.Write("How many lists do you want? ");
int listCount = int.Parse(Console.ReadLine()!);
Console.Write("How many numbers in total do you want to enter? ");
int count = int.Parse(Console.ReadLine()!);
int[] numbers = new int[listCount * count];
int total = 0;
for (int i = 0; i < listCount; i++)
{
    Console.WriteLine($"{i + 1}. list:");
    int listTotal = 0;
    while (listTotal < count)
    {
        Console.Write("Enter number (-1 to finish this list): ");
        int number = int.Parse(Console.ReadLine()!);
        if (number == -1)
        {
            break;
        }
        numbers[total] = number;
        total++;
        listTotal++;
    }
}
// Bubble Sort
for (int i = 0; i < total - 1; i++)
{
    for (int j = 0; j < total - 1 - i; j++)
    {
        if (numbers[j] > numbers[j + 1])
        {
            int temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
        }
    }
}
Console.WriteLine("Final List:");
for (int i = 0; i < total; i++)
{
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();