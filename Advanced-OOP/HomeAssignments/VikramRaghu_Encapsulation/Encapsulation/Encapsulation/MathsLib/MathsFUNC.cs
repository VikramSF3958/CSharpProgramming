namespace MathsLib;
public class MathsFUNC
{
    protected internal double PI = 3.14;
    internal double g = 9.8;
    public double Weight { get; set; }
    public MathsFUNC(){

    }
    public void CalculateWeight(double mass){
        Weight = mass * g;
        System.Console.WriteLine($"Weight : {Weight.ToString("0.00")}");
    }
}