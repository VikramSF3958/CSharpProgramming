using MathsLib;
namespace CalculatorApp;
public class CircleArea:MathsFUNC
{
    protected double radius;
    public double Radius { get; set; }
    internal double Area { get; set; }

    public CircleArea()
    {
        
    }

    public void GetData()
    {
        System.Console.Write("Enter the radius : ");
        Radius = double.Parse(Console.ReadLine());
    }
    public double CalculateArea()
    {
        Area = PI * Radius * Radius;
        return Area;
    }

}