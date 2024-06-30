namespace ClassesStructsAndRecords;

// Class
public class RGBColorClass
{
    public int Red { get; set; }
    public int Green { get; set; }
    public int Blue { get; set; }

    public RGBColorClass(int red, int green, int blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }
}

// Struct
public struct RGBColorStruct
{
    public int Red { get; set; }
    public int Green { get; set; }
    public int Blue { get; set; }

    public RGBColorStruct(int red, int green, int blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }
}

// Record
public record RGBColorRecord
{
    public int Red { get; init; }
    public int Green { get; init; }
    public int Blue { get; init; }

    public RGBColorRecord(int red, int green, int blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }
}

public class Program
{
    public static void Main6()
    {
        // Create instances
        var colorClass = new RGBColorClass(255, 0, 0); // Red
        var colorStruct = new RGBColorStruct(0, 255, 0); // Green
        var colorRecord = new RGBColorRecord(0, 0, 255); // Blue

        // Mutate instances
        colorClass.Red = 128;
        colorStruct.Green = 128;
        // colorRecord.Blue = 128; // This would cause a compile error because records are immutable

        // Pass instances to a method
        MutateColor(colorClass); //The changes will be reflected in the original object. (0, 0, 0)
        MutateColor(colorStruct); // Because structs are value types, these changes won't affect the original object. (0, 128, 0)
        // MutateColor(colorRecord); // This would cause a compile error because records are immutable

        // Print the color values
        Console.WriteLine($"Class: {colorClass.Red}, {colorClass.Green}, {colorClass.Blue}");
        Console.WriteLine($"Struct: {colorStruct.Red}, {colorStruct.Green}, {colorStruct.Blue}");
        Console.WriteLine($"Record: {colorRecord.Red}, {colorRecord.Green}, {colorRecord.Blue}");

        // Create instances
        var colorClass1 = new RGBColorClass(255, 0, 0); // Red
        var colorClass2 = new RGBColorClass(255, 0, 0); // Red

        var colorStruct1 = new RGBColorStruct(0, 255, 0); // Green
        var colorStruct2 = new RGBColorStruct(0, 255, 0); // Green

        var colorRecord1 = new RGBColorRecord(0, 0, 255); // Blue
        var colorRecord2 = new RGBColorRecord(0, 0, 255); // Blue

        // Compare instances for equality
        // For the RGBColorClass instances, the == operator and `.Equals` checks for reference equality, not value equality. Since colorClass1 and colorClass2 are different objects, the result is false. However, `.Equals` can be overridden to check for value equality.

        // For the RGBColorStruct instances, the Equals method checks for value equality. Since colorStruct1 and colorStruct2 have the same color values, the result is true. We can't use the == operator with structs.

        // For the RGBColorRecord instances, the == operator and `.Equals` checks for value equality, not reference equality. This is a feature of records in C#. Since colorRecord1 and colorRecord2 have the same color values, the result is true.
        Console.WriteLine($"Class equality: {colorClass1 == colorClass2}"); // False
        Console.WriteLine($"Class equality: {colorClass1.Equals(colorClass2)}"); // False
        Console.WriteLine($"Struct equality: {colorStruct1.Equals(colorStruct2)}"); // True
        Console.WriteLine($"Record equality: {colorRecord1 == colorRecord2}"); // True
        Console.WriteLine($"Record equality: {colorRecord1.Equals(colorRecord2)}"); // True
    }

    public static void MutateColor(RGBColorClass color)
    {
        color.Red = 0;
        color.Green = 0;
        color.Blue = 0;
    }

    public static void MutateColor(RGBColorStruct color)
    {
        color.Red = 0;
        color.Green = 0;
        color.Blue = 0;
    }

}
