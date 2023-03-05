int[] numbers = { 2, 4, 1, 9, 7 };
int change_number = 0;
for (int i = 0; i < numbers.Length-1; i++)
{
    if (numbers[i] > numbers[i + 1])
    {
        change_number = numbers[i];
        numbers[i] = numbers[i + 1];
        numbers[i + 1] = change_number;
      //  i = -1;
    }
}
//Console.WriteLine(numbers[i]);
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
