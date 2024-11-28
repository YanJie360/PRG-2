// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

static void admin_Menu()
{
    Console.WriteLine("------------- MENU --------------");
    Console.WriteLine("[1] Calculate Body Mass Index");
    Console.WriteLine("[2] Calculate Discount");
    Console.WriteLine("[3] Display Multiplication Table");
    Console.WriteLine("[0] Exit");
    Console.WriteLine("---------------------------------");
}

static void bmi()
{
    Console.WriteLine();
    Console.Write("Enter your weight (kg):  ");
    float weight = Convert.ToSingle(Console.ReadLine());


    Console.Write("Enter your height (m): ");
    float height = Convert.ToSingle(Console.ReadLine());

    double bmi = weight / (float)Math.Pow(height, 2);
    Console.WriteLine($"Your bmi is {bmi:F2}");

    string health_Cat;
    if (bmi < 18.5)
    {
        health_Cat = "Under weight";
    }
    else if (bmi < 23)
    {
        health_Cat = "Normal weight";
    }
    else if (bmi < 27.5)
    {
        health_Cat = "Over weight";
    }
    else
    {
        health_Cat = "Obese";
    }

    Console.WriteLine($"You are {health_Cat}.");

    Console.WriteLine();
    admin_Menu();
}

static void discount()
{
    Console.WriteLine();
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

    Console.WriteLine();
    admin_Menu();
}

static void multiple()
{
    Console.WriteLine();
    Console.Write("Enter a number: ");
    int number;
    number = Convert.ToInt32(Console.ReadLine());

    foreach (int numeral in Enumerable.Range(1, 12))
    {
        int product = numeral * number;
        Console.WriteLine($"{numeral} \t {product}");
    }

    Console.WriteLine();
    admin_Menu();
}

admin_Menu();

while (true)
{
    Console.Write("Enter your option: ");
    string option = Console.ReadLine();

    if (option == "1")
    {
        bmi();
    }
    else if (option == "2")
    {
        discount();
    }
    else if (option == "3")
    {
        multiple();
    }
    else if (option == "0")
    {
        Console.WriteLine("Bye");
        break;
    }
    else
    {
        Console.WriteLine("Invalid option! Please try again.");
    }
}
