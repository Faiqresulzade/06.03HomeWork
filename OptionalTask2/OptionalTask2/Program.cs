int[] numbers = { 2, 3, 6, 9, 12,19,21,22,23};
int searched_number = 23;
double step_double = Math.Sqrt(numbers.Length);
int step = (int)step_double;
int i = 0;
while (searched_number != numbers[i])
{
    if (searched_number > numbers[i])
    {
        i = i + step;
        numbers[i]=searched_number;
        if (i > numbers.Length - 1 && searched_number == numbers[numbers.Length - 1])
        {
            Console.WriteLine(numbers[numbers.Length - 1]);
            return;
        }
        if (i > numbers.Length - 1)
        {
            Console.WriteLine("Bele reqem yoxdur!!");
            return;
        }
    }
    if(searched_number < numbers[i])
    {
        i = step--;
    }
}
if(searched_number == numbers[i])
{
    Console.WriteLine(numbers[i]);
}