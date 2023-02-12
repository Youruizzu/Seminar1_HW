internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number%2 == 0) { Console.WriteLine($"Число {number} является чётным");}
        if (number%2 != 0) { Console.WriteLine($"Число {number} является нечётным");}
    }
}