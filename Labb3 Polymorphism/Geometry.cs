namespace Labb3_Polymorphism
{
    public abstract class Geometry
    {
        public string Shape { get; set; } = "No shape found";
        public abstract double Area();
    }
}
