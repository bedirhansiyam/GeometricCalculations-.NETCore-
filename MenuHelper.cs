namespace GeometricCalculations;

public static class MenuHelper
{
    public static void GetMenu()
    {
        Console.Clear();
        Console.WriteLine("Please select the geometric shape you want to calculate");
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("1) Square");
        Console.WriteLine("2) Rectangle");
        Console.WriteLine("3) Triangle");
        Console.WriteLine("4) Circle");
        Console.WriteLine("0) Exit");
        Console.WriteLine();
        Console.Write("Your selection : ");
    }
    public static void ControlSelection(out int selection, out bool selectionController, int max)
    {
        do
        {
            selectionController = int.TryParse(Console.ReadLine(), out selection);
            if (selection >= 0 && selection <= max && selectionController == true)
                selectionController = true;
            else
                selectionController = false;
            if (selectionController == false)
                Console.Write("Please make a valid selection : ");
        } while (selectionController == false);
    }
    public static void ControlSelection(out int selection, out bool selectionController)
    {
        do
        {
            selectionController = int.TryParse(Console.ReadLine(), out selection);
            if (selection >= 1  && selectionController == true)
                selectionController = true;
            else
                selectionController = false;
            if (selectionController == false)
                Console.Write("Please make a valid selection : ");
        } while (selectionController == false);
    }

    public static void Header(string head)
    {
        Console.Clear();
        Console.WriteLine(head);
        Console.WriteLine();
    }
    public static void GetSubMenu()
    {                
        Console.WriteLine("Please select what you want to calculate");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine();
        Console.WriteLine("1) Perimeter");
        Console.WriteLine("2) Area");
        Console.WriteLine("3) Volume");
        Console.WriteLine("0) Exit");
        Console.WriteLine();
        Console.Write("Your selection : ");        
    }
    public static void ReturnMainMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Please press any key to continue!");
        Console.ReadKey();
    }
}