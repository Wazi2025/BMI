namespace BMI;

class Program
{
    class Person
    {
        public double HeightFloat { get; set; }
        public double WeightFloat { get; set; }
        public double Bmi { get; set; }
        public string? Input { get; set; }
        public string TextHeight = "Please type in your height (in cm): ";
        public string TextWeight = "Please type in your weight (in kg): ";
    }
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
        //Instantiate new Person object
        Person person = new Person();

        person.HeightFloat = ValidateInput(person.Input, person.TextHeight);
        person.WeightFloat = ValidateInput(person.Input, person.TextWeight);

        person.Bmi = person.WeightFloat / (person.HeightFloat / 100 * person.HeightFloat / 100);

        Console.WriteLine($"Your BMI is: {person.Bmi:F2}");
    }
}
