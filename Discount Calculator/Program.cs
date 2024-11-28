// See https://aka.ms/new-console-template for more information

Console.Write("Enter amount    ($): ");
double amount = Convert.ToSingle(Console.ReadLine());

double discount_Given;
if (amount <= 100)
{
    discount_Given = 0;
}
else if (amount <= 500)
{
    discount_Given = 0.05;
}
else if (amount <= 1000)
{ 
    discount_Given = 0.1;
}
else
{
    discount_Given = 0.2;
}

double discount_Amount = amount * discount_Given;

Console.WriteLine($"Discount given  (%): {discount_Given * 100}");
Console.WriteLine($"Discount amount ($): {discount_Amount:F2}");
