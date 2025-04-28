namespace BMI;

class Program
{
    static double ValidateInput(string? input, string text)
    {
        double output;

        //Repeat loop as long as input is empty or the parse fails (by using letters for instance)
        while (string.IsNullOrWhiteSpace(input) || !double.TryParse(input, out output))
        {
            Console.WriteLine(text);
            input = Console.ReadLine();
        }

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
