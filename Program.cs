namespace LearnClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(20, 10);
            double area  = rectangle.CalculateArea();
            double parimeter = rectangle.CalculateParimeter();
            Console.WriteLine("The Area of the Rectangle is {0}", area);
            Console.WriteLine("The Parimeter of the Rectangle is {0}", parimeter);
        }
    }
}