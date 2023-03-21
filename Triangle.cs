namespace GeometricCalculations;

public static class Triangle
{
    public static int Perimeter(int side1, int side2, int side3)
    {
        return side1 + side2 + side3;
    }
    public static double Area(int baseLength, int height)
    {
        double result = (Convert.ToDouble(baseLength) * Convert.ToDouble(height)) / 2;
        return result;
    }
    public static double Volume(int baseLength, int heightTriangle, int height)
    {
        double result = ((Convert.ToDouble(baseLength) * Convert.ToDouble(heightTriangle)) / 2) * height ;
        return result;
    }
}