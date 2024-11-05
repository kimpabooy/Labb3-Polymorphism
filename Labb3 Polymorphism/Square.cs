namespace Labb3_Polymorphism
{
    public class Square : Geometry
    {
        public double OneSide { get; set; }

        public Square()
        {
            OneSide = 5;
            Shape = "Fyrkant";
        }
        // A = OneSide^2
        public override double Area() => Math.Pow(OneSide, 2);
    }
}
