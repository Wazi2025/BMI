namespace BMI;

class Program
{

    static double ValidateInput(string? input, string text)
    {
        double output = 0;

        while (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine(text);
            input = Console.ReadLine();
        }
        double.TryParse(input, out output);

        return output;
    }
    static void Main(string[] args)
    {
        double heightFloat;
        double weightFloat;
        double bmi;
        string input = "";
        const string textHeight = "Please type in your height (in cm): ";
        const string textWeight = "Please type in your weight (in kg): ";

        heightFloat = ValidateInput(input, textHeight);
        weightFloat = ValidateInput(input, textWeight);

        bmi = weightFloat / (heightFloat / 100 * heightFloat / 100);

        Console.WriteLine($"Your BMI is: {bmi:F2}");
    }
}
