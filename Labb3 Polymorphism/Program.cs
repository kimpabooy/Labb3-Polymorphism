namespace Labb3_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Geometry circle = new Circle();
            Geometry square = new Square();
            Geometry rectangle = new Rectangle();

            List<Geometry> forms = new List<Geometry> { circle, square, rectangle };
            
            foreach (Geometry form in forms )
            {
                Console.WriteLine($"Arean av {form.Shape}en är {form.Area()}cm.");
            }
            
            Console.ReadKey();
        }
    }
}
