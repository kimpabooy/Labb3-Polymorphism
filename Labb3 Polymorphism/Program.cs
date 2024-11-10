namespace Labb3_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating different objects of the type Geometry.
            Geometry circle = new Circle();
            Geometry square = new Square();
            Geometry rectangle = new Rectangle();

            // Creating a generic List of type Geometry with diffrent objects { circle, square, rectangle }.
            List<Geometry> forms = new List<Geometry> { circle, square, rectangle };
            
            foreach (Geometry form in forms) // Iterates through the list forms as Geometry types.
            {
                Console.WriteLine($"Arean av {form.Shape}en är {form.Area()}cm.");
            }
            
            Console.ReadKey();

            /*
              Polymorfism betyder "många former" och innebär att ett objekt kan ha olika former
              men endå utgå ifrån samma typ/klass. Man kan bara använda sig utav de metoder
              och egenskaper som finns i den klassen som man skapar objektet ifrån.
             */
        }
    }
}
