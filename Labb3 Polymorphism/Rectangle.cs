namespace Labb3_Polymorphism
{
    public class Rectangle : Geometry
    {
        public double Base { get; set; }
        public double Hight { get; set; }
        public Rectangle()
        {
            Base = 5;
            Hight = 3;
            Shape = "Rektangel";
        }
        
        // Area = Base * Hight
        public override double Area() => Base * Hight;

        //public override double Area()
        //{
        //    return Base * Hight;
        //}
    }
}
