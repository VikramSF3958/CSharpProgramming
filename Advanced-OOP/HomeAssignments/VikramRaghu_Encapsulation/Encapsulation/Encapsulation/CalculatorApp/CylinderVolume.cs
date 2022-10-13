namespace CalculatorApp;
public class CylinderVolume:CircleArea
{

    public double Height { get; set; }
    internal double Volume { get; set; }
    public CylinderVolume()
    {
        
    }

    public void GetHeightData()
    {
        System.Console.Write("Enter the height : ");
        Height = double.Parse(Console.ReadLine());
    }
    public void CalculateVolume()
    {
        Volume = 3.14 * Radius * Radius * Radius;
        System.Console.WriteLine($"Volume : {Volume}");
    }
}