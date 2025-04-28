namespace BMI;

class Program
{
    static void Main(string[] args)
    {
        double heightFloat = 0;
        double weightFloat = 0;
        double bmi;


        Console.WriteLine("Please type in your height (in cm): ");
        string height = Console.ReadLine();
        Console.WriteLine("Please type in your weight (in kg): ");
        string weight = Console.ReadLine();

        double.TryParse(height, out heightFloat);
        double.TryParse(weight, out weightFloat);

        bmi = weightFloat / (heightFloat / 100 * heightFloat / 100);

        Console.WriteLine($"Your BMI is: {bmi:F2}");

    }
}
