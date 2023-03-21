namespace GeometricCalculations;

public static class Rectangle
{
    public static int Perimeter(int shortSide, int longSide)
    {
        return (shortSide + longSide) * 2;
    }
    public static int Area(int shortSide, int longSide)
    {
        return shortSide * longSide;
    }
    public static int Volume(int shortSide, int longSide, int height)
    {
        return shortSide * longSide * height;
    }
}