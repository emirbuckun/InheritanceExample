namespace InheritanceExample
{
  internal class Rectangle : Shape
  {
    public int Width { get; set; }
    public int Height { get; set; }

    public override void CalculateArea()
    {
      base.CalculateArea();
      int area = Width * Height;
      Console.WriteLine($"Rectangle area {area}");
    }
  }
}