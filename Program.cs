namespace GeometricCalculations;
class Program
{
    private static int limit;

    static void Main(string[] args)
    {
        int selection;
        bool selectionController;
        do
        {
            MenuHelper.GetMenu();
            MenuHelper.ControlSelection(out selection, out selectionController, 4);

            switch (selection)
            {
                case 1:
                    MenuHelper.Header("SQUARE");
                    MenuHelper.GetSubMenu();
                    MenuHelper.ControlSelection(out selection, out selectionController,3);

                        switch (selection)
                        {
                            case 1:
                                MenuHelper.Header("SQUARE - PERIMETER CALCULATION" );
                                Console.Write("Please enter the side length of the square (cm) : ");
                                MenuHelper.ControlSelection(out int length, out selectionController);
                                Console.WriteLine("");
                                Console.WriteLine("Perimeter of the square = " + Square.Perimeter(length) + " cm");
                            break;
                            case 2:
                                MenuHelper.Header("SQUARE - AREA CALCULATION" );
                                Console.Write("Please enter the side length of the square (cm) : ");
                                MenuHelper.ControlSelection(out length, out selectionController);
                                Console.WriteLine("");
                                Console.WriteLine("Area of the square = " + Square.Area(length) + " cm²");
                            break;
                            case 3:
                                MenuHelper.Header("SQUARE - VOLUME CALCULATION" );
                                Console.Write("Please enter the side length of the square (cm) : ");
                                MenuHelper.ControlSelection(out length, out selectionController);
                                Console.WriteLine("");
                                Console.WriteLine("Volume of the square = " + Square.Volume(length) + " cm³");
                            break;
                            default:
                            break;
                        }

                    MenuHelper.ReturnMainMenu();
                    break;
                case 2:
                    MenuHelper.Header("RECTANGLE");
                    MenuHelper.GetSubMenu();
                    MenuHelper.ControlSelection(out selection, out selectionController,3);

                        switch (selection)
                        {
                            case 1:
                                MenuHelper.Header("RECTANGLE - PERIMETER CALCULATION" );

                                Console.Write("Please enter the short side length of the rectangle (cm) : ");
                                MenuHelper.ControlSelection(out int shortSide, out selectionController);

                                Console.Write("Please enter the long side length of the rectangle (cm) : ");
                                MenuHelper.ControlSelection(out int longSide, out selectionController);
                                Console.WriteLine("");
                                Console.WriteLine("Perimeter of the rectangle = " + Rectangle.Perimeter(shortSide,longSide) + " cm");
                            break;
                            case 2:
                                MenuHelper.Header("RECTANGLE - AREA CALCULATION" );

                                Console.Write("Please enter the short side length of the rectangle (cm) : ");
                                MenuHelper.ControlSelection(out shortSide, out selectionController);

                                Console.Write("Please enter the long side length of the rectangle (cm) : ");
                                MenuHelper.ControlSelection(out longSide, out selectionController);
                                Console.WriteLine("");
                                Console.WriteLine("Area of the rectangle = " + Rectangle.Area(shortSide,longSide) + " cm²");
                            break;
                            case 3:
                                MenuHelper.Header("RECTANGLE - VOLUME CALCULATION" );

                                Console.Write("Please enter the short side length of the rectangle (cm) : ");
                                MenuHelper.ControlSelection(out shortSide, out selectionController);

                                Console.Write("Please enter the long side length of the rectangle (cm) : ");
                                MenuHelper.ControlSelection(out longSide, out selectionController);

                                Console.Write("Please enter the height of the rectangle (cm) : ");
                                MenuHelper.ControlSelection(out int height, out selectionController);
                                Console.WriteLine("");
                                Console.WriteLine("Volume of the rectangle = " + Rectangle.Volume(shortSide,longSide,height) + " cm³");
                            break;
                            default:
                            break;
                        }

                    MenuHelper.ReturnMainMenu();
                    break;
                case 3:
                    MenuHelper.Header("TRIANGLE");
                    MenuHelper.GetSubMenu();
                    MenuHelper.ControlSelection(out selection, out selectionController,3);

                        switch (selection)
                        {
                            case 1:
                                MenuHelper.Header("TRIANGLE - PERIMETER CALCULATION" );

                                Console.Write("Please enter the first side length of the triangle (cm) : ");
                                MenuHelper.ControlSelection(out int firstSide, out selectionController);

                                Console.Write("Please enter the second side length of the triangle (cm) : ");
                                MenuHelper.ControlSelection(out int secondSide, out selectionController);

                                Console.Write("Please enter the third side length of the triangle (cm) : ");
                                MenuHelper.ControlSelection(out int thirdSide, out selectionController);

                                Console.WriteLine("");
                                Console.WriteLine("Perimeter of the triangle = " + Triangle.Perimeter(firstSide, secondSide, thirdSide) + " cm");
                            break;
                            case 2:
                                MenuHelper.Header("TRIANGLE - AREA CALCULATION" );

                                Console.Write("Please enter the base length of the triangle (cm) : ");
                                MenuHelper.ControlSelection(out int baseLength, out selectionController);

                                Console.Write("Please enter the height of the triangle (cm) : ");
                                MenuHelper.ControlSelection(out int height, out selectionController);
                                Console.WriteLine("");
                                Console.WriteLine("Area of the triangle = " + Triangle.Area(baseLength, height) + " cm²");
                            break;
                            case 3:
                                MenuHelper.Header("TRIANGLE - VOLUME CALCULATION" );

                                Console.Write("Please enter the base length of the triangle (cm) : ");
                                MenuHelper.ControlSelection(out baseLength, out selectionController);

                                Console.Write("Please enter the height of the triangle (cm) : ");
                                MenuHelper.ControlSelection(out int heightTriangle, out selectionController);

                                Console.Write("Please enter the height of the triangular prism (cm) : ");
                                MenuHelper.ControlSelection(out height, out selectionController);
                                Console.WriteLine("");
                                Console.WriteLine("Volume of the triangular prism = " + Triangle.Volume(baseLength, heightTriangle, height) + " cm³");
                            break;
                            default:
                            break;
                        }

                    MenuHelper.ReturnMainMenu();
                    break;
                case 4:
                    MenuHelper.Header("CIRCLE");
                    MenuHelper.GetSubMenu();
                    MenuHelper.ControlSelection(out selection, out selectionController,3);

                        switch (selection)
                        {
                            case 1:
                                MenuHelper.Header("CIRCLE - PERIMETER CALCULATION" );
                                Console.Write("Please enter the radius of the circle (cm) : ");
                                MenuHelper.ControlSelection(out int radius, out selectionController);
                                Console.WriteLine("");
                                Console.WriteLine("Perimeter of the circle = " + Math.Round(Circle.Perimeter(radius),2) + " cm");
                            break;
                            case 2:
                                MenuHelper.Header("CIRCLE - AREA CALCULATION" );
                                Console.Write("Please enter the radius of the circle (cm) : ");
                                MenuHelper.ControlSelection(out radius, out selectionController);
                                Console.WriteLine("");
                                Console.WriteLine("Area of the circle = " + Math.Round(Circle.Area(radius),2) + " cm²");
                            break;
                            case 3:
                                MenuHelper.Header("CIRCLE - VOLUME CALCULATION" );
                                Console.Write("Please enter the radius of the circle (cm) : ");
                                MenuHelper.ControlSelection(out radius, out selectionController);
                                Console.WriteLine("");
                                Console.WriteLine("Volume of the circle = " + Math.Round(Circle.Volume(radius),2) + " cm³");
                            break;
                            default:
                            break;
                        }

                    MenuHelper.ReturnMainMenu();
                    break;
                default:
                    break;
            }
        } while (selection != 0);
    }

    
}
