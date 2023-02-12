internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Введите первое число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int b = Convert.ToInt32(Console.ReadLine());
        if (a > b) {
            Console.WriteLine($"a (= {a}) > b (= {b})");
        }
        else {
            Console.WriteLine($"b (= {b}) > a (= {a})");
        }
    }
}