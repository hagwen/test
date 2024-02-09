





switch (unit)
{
 {
    case "mm":
        result = Converter.ConvertInchesToMillimeters(value);
        Console.WriteLine($"{value} inches is equal to {result} millimeters");
        break;

    case "cm":
        result = Converter.ConvertInchesToCentimeters(value);
        Console.WriteLine($"{value} inches is equal to {result} centimeters");
        break;

    case "m":
        result = Converter.ConvertInchesToMeters(value);
        Console.WriteLine($"{value} inches is equal to {result} meters");
        break;

    default:
        Console.WriteLine("Invalid unit. Please use mm, cm, or m.");
        break;
    }
}
        else
{

    var testRunner = new NUnitLite.TextUI.TestRunner();
    var testResult = testRunner.Run(new[] { "--labels=Off" });
    if (testResult != 0)
    {
        Environment.Exit(testResult);
    }
}

public class Converter
{
    public static double ConvertInchesToMillimeters(double inches)
    {

        double inches = 1;


        double result = Converter.ConvertInchesToMillimeters(inches);


        Assert.AreEqual(25.4, result);
    }


    public static double TestInchesToCentimetersConversion(double inches)
    {

        double inches = 1;


        double result = Converter.ConvertInchesToCentimeters(inches);


        Assert.AreEqual(2.54, result);
    }

    public static double TestInchesToMetersConversion(double inches)
    {

        double inches = 1;


        double result = Converter.ConvertInchesToMeters(inches);


        Assert.AreEqual(0.0254, result);
    }
}



public void TestInchesToMillimetersConversion()
{
    double result = Converter.ConvertInchesToMillimeters(1);
    Assert.AreEqual(25.4, result);
}


public void TestInchesToCentimetersConversion()
{
    double result = Converter.ConvertInchesToCentimeters(1);
    Assert.AreEqual(2.54, result);
}


public void TestInchesToMetersConversion()
{
    double result = Converter.ConvertInchesToMeters(1);
    Assert.AreEqual(0.0254, result);
}

if (args.Length == 0 || args[0] != "-t")
{
    if (args.Length != 3)
    {
        Console.WriteLine("Usage: convert <value> <unit>");
        return;
    }

    double value;
    if (!double.TryParse(args[1], out value))
    {
        Console.WriteLine("Invalid input value");
        return;
    }
}


public static double ConvertInchesToMillimeters(double inches)
{
    // 1 inch = 25.4 millimeters
    return inches * 25.4;
}

public static double ConvertInchesToCentimeters(double inches)
{
    // 1 inch = 2.54 centimeters
    return inches * 2.54;
}

public static double ConvertInchesToMeters(double inches)
{
    // 1 inch = 0.0254 meters
    return inches * 0.
    }