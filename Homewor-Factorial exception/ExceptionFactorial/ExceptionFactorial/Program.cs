

using ExceptionFactorial;

static void Nums(int n)
{
    int multiply = 1;
    try
    {
        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                multiply *= i;
            }
            Console.WriteLine(multiply);
        }
        else
        {
            throw new NotFoundException("Data Not Fount");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
Nums(-5);
