int Input(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task25()
{
    int num1 = Input("Enter first number");
    int num2 = Input("Enter second number");

    double result = Math.Pow(num1, num2);
    Console.Write(result);
}

void Task27()
{
    int num = Input("Enter a number");
    int sum = 0;
    int counter = 0;
    int digit = 0;
    while (num > 0)
    {
        digit = num%10;
        sum = sum + digit;
        num = num/10;
    }
    Console.WriteLine(sum);
}

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while(index<length)
    {
        array[index]=new Random().Next(-100,100);
        index++;
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while(position<count)
    {
        Console.Write(array[position] + " ");
        position++;
    }
}

void SelectionSort(int [] array)
{
    for (int i = 0; i<array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j<array.Length; j++)
        {
            if(Math.Abs(array[i]) < Math.Abs(array[j]))
            {
                minPosition = j;
            }
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
int[] array = new int[8];
FillArray(array);
SelectionSort(array);
PrintArray(array);