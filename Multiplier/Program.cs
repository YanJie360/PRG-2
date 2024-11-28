// See https://aka.ms/new-console-template for more information

Console.Write("Enter a number: ");
int number;
number = Convert.ToInt32(Console.ReadLine());

foreach (int numeral in Enumerable.Range(1, 12))
{
    int product = numeral * number;
    Console.WriteLine($"{numeral} \t {product}");
}
