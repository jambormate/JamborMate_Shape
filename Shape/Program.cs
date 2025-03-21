using System.Drawing;
using System.Threading.Channels;

namespace Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Rectangle(false, "Red", 5, 4),  
                new Square(true, "Blue", 1,1 ),
                new Circle("Black", 2),
                new Square(false, "Green", 2, 2),
                new Rectangle(true, "Red", 2, 5),
            };
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.pop());
            }
            Shape shape1 = sep("Green", 5, 5);  
            Shape shape2 = sep("Purple", 2, 4); 

            Console.WriteLine(shape1); 
            Console.WriteLine(shape2);
            Shape legnagyobb = MAXarea(shapes);
            Console.WriteLine($"A legnagyobb területű alakzat: {legnagyobb}");
        }
        public static Shape sep(string color, double side1, double side2)
        {
            if (side1 == side2)
            {
                return new Square(true, color, side1, side2);
            }
            else
            {
                return new Rectangle(false, color, side1, side2); 
            }
        }
        public static Shape MAXarea(Shape[] shapes)
        {
            Shape legnagyobbAlakzat = shapes[0]; 
            double max = legnagyobbAlakzat.Area(); 

            foreach (var shape in shapes)
            {
                double mostani = shape.Area(); 
                if (mostani > max) 
                {
                    legnagyobbAlakzat = shape; 
                    max = mostani; 
                }
            }
            return legnagyobbAlakzat; 
        }
    }
}
