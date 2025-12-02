public class Rectangle
{
    public double length;
    public double breadth;
    public double Length {
        get =>  length;
        set => length = value;
     }
    public double Breadth { 
        get => breadth;
        set => breadth = value;
     }

   public double GetArea() => length * breadth;
   public string ShowDetails() => $"Length: {length}\nBreadth: {breadth}";
   public double CalculatePerimeter() => 2 * (length + breadth);
}
