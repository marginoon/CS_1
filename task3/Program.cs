using System.Security.Cryptography;

namespace task3
{
    public class Point
    {
        private int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y;  }
        }
        
    }

    public class Figure
    {
        string name;
       
        private List<Point> points = new();

        public Figure(string name, Point p1, Point p2, Point p3)
        {
            this.name = name;
            this.points.Add(p1);
            this.points.Add(p2);
            this.points.Add(p3);
        }
        
        public Figure(string name, Point p1, Point p2, Point p3,  Point p4)
        {
            this.name = name;
            this.points.Add(p1);
            this.points.Add(p2);
            this.points.Add(p3);
            this.points.Add(p4);
        }
        
        public Figure(string name, Point p1, Point p2, Point p3 ,  Point p4, Point p5)
        {
            this.name = name;
            this.points.Add(p1);
            this.points.Add(p2);
            this.points.Add(p3);
            this.points.Add(p4);
            this.points.Add(p5);
        }

        public string Name
        {
            get { return name; }
        }
        public double LengthSide(Point A, Point B)
        {
           return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }

        public double PerimeterCalculator()
        {
            double sum = 0;
            var amount = points.Count;
            for (int i = 0; i < amount; i++)
            {
                sum += LengthSide(points[i], points[(i + 1) % amount]);
            }
            return sum;
        }
    }
    
    public class Main_Prog
    {
        static void Main()
        {
            Console.WriteLine(" name:");
            string name = Console.ReadLine();
            Console.WriteLine("number of points");
            int amount = Convert.ToInt16(Console.ReadLine());
            List <Point> points = new();
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("Enter X");
                int x = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter Y");
                int y = Convert.ToInt16(Console.ReadLine());
                points.Add(new(x, y));
            }
            
            Figure fex;
            if (amount == 3)
            {
                fex = new(name, points[0], points[1], points[2]);
            }
            else if (amount == 4)
            {
                fex = new(name, points[0], points[1] , points[2] ,
                    points[3]);
            }
            else if (amount == 5)
            {
                fex = new(name, points[0], points[1] , points[2] ,
                    points[3] , points[4]);
            }
            else
            {
                return;
            }
            Console.WriteLine("{0} , perimetr: {1}", fex.Name, fex.PerimeterCalculator());
        }
    }
}