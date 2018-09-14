using System;
namespace Application
{
    class Shape
    {
        public void setSide(int s)
        {
            side = s;
        }
        protected int side;
    }
    // Base class Cost
    public interface Cost
    {
        int getCost(int area);
    }
    // Derived class
    class square : Shape, Cost
    {
        public int getArea()
        {
            return (side * side);
        }
        public int getCost(int area)
        {
            return area * 10;
        }
    }
    class Square
    {
        static void Main(string[] args)
        {
            square sq = new square();
            int area;
            sq.setSide(5);
            area = sq.getArea();

            // Print the area of the object.
            Console.WriteLine("The area is: {0}", sq.getArea());
            Console.WriteLine("The cost is: {0}", sq.getCost(area));
            Console.ReadKey();
        }
    }
}