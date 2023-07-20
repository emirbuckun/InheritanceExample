namespace InheritanceExample
{
  public class Shape
  {
    public string? Color { get; set; }
    public virtual void CalculateArea()
    {
      Console.WriteLine("Shape CalculateArea()");
    }
  }
}