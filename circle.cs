namespace VariablesAndDatatypes
{
    public class Circle
    {
        // Constant PI
        public const double PI = 3.14;

        // Stretch method: calculate area
        public double Area(double radius) => PI * radius * radius;

        // Stretch method: calculate perimeter / circumference
        public double Perimeter(double radius) => 2 * PI * radius;
    }
}
