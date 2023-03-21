namespace GeometricCalculations;

public static class Square
{
    public static int Perimeter(int sideLength)
    {
        return sideLength * 4;
    }
    public static int Area(int sideLength)
    {
        return sideLength * sideLength;
    }
    public static int Volume(int sideLength)
    {
        return sideLength * sideLength * sideLength;
    }
}