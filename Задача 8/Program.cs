internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write($"{number} ->");
        
        if (number > 0) {
            for (int i = 1; i <= number; i++) {
                if (i%2 == 0) { Console.Write($" {i}");}
            }    
        }
        if (number < 0) {
            for (int i = -1; i >= number; i--) {
                if (i%2 == 0) { Console.Write($" {i}");}
            }
        }
    }
}