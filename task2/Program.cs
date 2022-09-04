// See https://aka.ms/new-console-template for more information

namespace task2
{
    public class Rectangle
    {
        private double side1, side2;
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;

        }

        double AreaCalculator()
        {
            return side1 * side2;
            
        }

        double PerimetrCalculator()
        {
            return 2 * (side1 + side2);
        }

        public double Area
        {
            get { return AreaCalculator(); }
        }

        public double Perimetr
        {
            get { return PerimetrCalculator(); }
        }
    }

    public class Main_Program
    {
        static void Main()
        {
            Console.WriteLine("Enter 1 side");
            double side_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 2 side");
            double side_2 = Convert.ToDouble(Console.ReadLine());

            Rectangle ex = new(side_1, side_2);

            Console.WriteLine("Area: {0}", ex.Area);
            Console.WriteLine("Perimetr: {0}", ex.Perimetr);

        }
    }
}
