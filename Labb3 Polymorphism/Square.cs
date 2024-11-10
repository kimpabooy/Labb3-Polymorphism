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
        
        // Area = OneSide^2
        public override double Area() => Math.Pow(OneSide, 2);

        //public override double Area()
        //{
        //    return Math.Pow(OneSide, 2);
        //}
    }
}
