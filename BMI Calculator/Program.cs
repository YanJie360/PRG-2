// See https://aka.ms/new-console-template for more information

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