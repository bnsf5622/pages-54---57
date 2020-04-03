using System;
using System.Collections.Generic;
using System.Text;


namespace pages 
{
class Program
{
    static void Main(string[] args)
    {
        int rectArea = 0;
        int perimeter = 0;
        double area;
        double circumfrence;
        Console.Write("\n****Without   using   Ref/Out   paramter + Types ****");
        Calculate(10, 5, rectArea, perimeter);
        Console.Write("\nvalue of rectArea is:" + rectArea);
        Console.Write("\nvalue of perimeter is:" + perimeter);
        Calculate(5, 5, rectArea, perimeter);
        Console.Write("\nvalue of rectArea is:" + rectArea);
        Console.Write("\nvalue of perimeter is:" + perimeter);
        Console.Write("\n\n*******  Ref  Keyword  Example" +
"*********");
        Compute(10, 5, ref rectArea, ref perimeter);
        Console.Write("\nvalue of rectArea is:" + rectArea);
        Console.Write("\nvalue of perimiter is:" + perimeter);
        Compute(5, 5, ref rectArea, ref perimeter);
        Console.Write("\nvalue of rectArea is:" + rectArea);
        Console.Write("\nvalue of perimeter is:" + perimeter);
        AreaForCircle(10, out area, out circumfrence);
        Console.Write("\nvalue of area is:" + area);
        Console.Write("\nvalue  of  circumfrence  is:" +
circumfrence);
        Console.Read();
    }
    public static void Calculate(int side, int side1, int rectArea,
int perimeter)
    {
        if (side == side1)
        {
            Console.Write("\n\n******* FOR SQUARE *********");
            rectArea = side * side;
            perimeter = 4 * side;
        }
        else
        {
            Console.Write("\n\n*******  FOR  RECTANGLE *********");
            rectArea = side * side1;
            perimeter = 2 * (side + side1);
        }
    }

    public static void Compute(int side, int side1, ref int
rectArea, ref int perimeter)
    {
        if (side == side1)
        {
            Console.Write("\n\n******* FOR SQUARE *********");
            rectArea = side * side;
            perimeter = 4 * side;
        }
        else
        {
            Console.Write("\n\n******  FOR  RECTANGLE" +
   "*********");
            rectArea = side * side1;
            perimeter = 2 * (side + side1);
        }
    }
    public static void AreaForCircle(int radius, out double area,
        out double circumfrence)
    {
        Console.Write("\n\n*******  OUT  Keyword Example" +
 "*********");
        area = 3.14 * radius * radius;
        circumfrence = 2 * radius * 3.14;
    }
}
}     