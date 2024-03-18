public static double Square(double number)
{
    // We'll manually multiply the number by itself to get the square
    double square = number * number;
    return square;
}

public static void Main(string[] args)
{
    double num = 5.0;
    double result = Square(num);
    Console.WriteLine("Square of {0} is {1}", num, result);
}
