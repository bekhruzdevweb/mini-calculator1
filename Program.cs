using System;

public class BMI_Calculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("BMI Calculator");
        Console.WriteLine("----------------");

        Console.Write("Enter your weight in kilograms: ");
        if (!double.TryParse(Console.ReadLine(), out double weight) || weight <= 0)
        {
            Console.WriteLine("Invalid weight input. Please enter a positive number.");
            return;
        }

        Console.Write("Enter your height in meters: ");
        if (!double.TryParse(Console.ReadLine(), out double height) || height <= 0)
        {
            Console.WriteLine("Invalid height input. Please enter a positive number.");
            return;
        }

        double bmi = CalculateBMI(weight, height);

        Console.WriteLine($"Your BMI is: {bmi:F2}"); // :F2 formats to 2 decimal places

        DisplayBMIInterpretation(bmi);
    }

    public static double CalculateBMI(double weight, double height)
    {
        return weight / (height * height);
    }

    public static void DisplayBMIInterpretation(double bmi)
    {
        Console.WriteLine("BMI Interpretation:");

        if (bmi < 18.5)
        {
            Console.WriteLine("Underweight");
        }
        else if (bmi >= 18.5 && bmi < 25)
        {
            Console.WriteLine("Normal weight");
        }
        else if (bmi >= 25 && bmi < 30)
        {
            Console.WriteLine("Overweight");
        }
        else
        {
            Console.WriteLine("Obese");
        }
    }
}