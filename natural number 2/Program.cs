internal class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Введите четырёхзначное натуральное число:");
    var A = Convert.ToInt32(Console.ReadLine());

    var result = A/10;
    result%= 100;
    Console.WriteLine("Двузначное число, состоящее из его средних цифр:");
    Console.WriteLine(result);
  }
}
