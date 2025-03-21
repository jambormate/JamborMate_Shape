namespace Shape
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Rectangle rectangle = new Rectangle(false, "Red", 1, 2);
            Console.WriteLine(rectangle.ToString());
        }
	}
}
