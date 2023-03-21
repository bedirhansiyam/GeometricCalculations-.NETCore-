namespace GeometricCalculations;

public static class Circle
{
    public static double Perimeter(int radius)
    {
        double result = radius * Math.PI * 2;
        return result;
    }
    public static double Area(int radius)
    {
        double result = radius * radius * Math.PI;
        return result;
    }
    public static double Volume(int radius)
    {
        double result = (4 * Math.PI * Math.Pow(Convert.ToDouble(radius),3)) / 3;
        return result;
    }
}