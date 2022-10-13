using MathsLib;
namespace CalculatorApp;

class Program
{
    public static void Main(string[] args)
    {
        CircleArea circle = new CircleArea();
        circle.GetData();

        double AreaOfCircle = circle.CalculateArea();
        System.Console.WriteLine($"AreaOfCircle : {AreaOfCircle}");

        CylinderVolume cylinder = new CylinderVolume();
        cylinder.GetHeightData();
        cylinder.CalculateVolume();

        System.Console.Write("Enter the weight : ");
        double weight = double.Parse(Console.ReadLine());
        MathsFUNC weightValue = new MathsFUNC();
        weightValue.CalculateWeight(weight);
    }
}