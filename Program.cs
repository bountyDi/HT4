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
Task29()
{
    
}
