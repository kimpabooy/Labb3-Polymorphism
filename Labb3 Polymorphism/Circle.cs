namespace Labb3_Polymorphism
{
    public class Circle : Geometry
    {
        public double Radius { get; set; }
        public Circle()
        {
            Radius = 24;
            Shape = "Cirkel";
        }
        
        // Area = π (r x r)
        public override double Area() => Math.PI * Radius * Radius;
        
        //public override double Area()
        //{
        //    return Math.PI * Radius * Radius;
        //}
    }
}
