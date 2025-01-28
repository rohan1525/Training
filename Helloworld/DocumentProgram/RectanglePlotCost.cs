using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class RectanglePlotCost
    {
        class Rectangle
        {
            protected double Length { get; set; }
            protected double Width { get; set; }

            public void GetDimensions()
            {
                Console.Write("Enter the length of the rectangle: ");
                Length = double.Parse(Console.ReadLine());

                Console.Write("Enter the width of the rectangle: ");
                Width = double.Parse(Console.ReadLine());
            }

            public double CalculateArea()
            {
                return Length * Width;
            }
        }
        class PlotCost : Rectangle
        {
            private double CostPerUnit { get; set; }

            public void GetCostPerUnit()
            {
                Console.Write("Enter the cost per square meter: ");
                CostPerUnit = double.Parse(Console.ReadLine());
            }

            public void DisplayCost()
            {
                double area = CalculateArea();
                double totalCost = area * CostPerUnit;

                Console.WriteLine($"\nLength of the plot: {Length} meters");
                Console.WriteLine($"Width of the plot: {Width} meters");
                Console.WriteLine($"Area of the plot: {area} square meters");
                Console.WriteLine($"Cost per square meter: {CostPerUnit:C}");
                Console.WriteLine($"Total cost of the plot: {totalCost:C}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                PlotCost plot = new PlotCost();

                Console.WriteLine("Rectangle Plot Cost Calculator");

                plot.GetDimensions();
                plot.GetCostPerUnit();

                plot.DisplayCost();
            }
        }
    }
}
