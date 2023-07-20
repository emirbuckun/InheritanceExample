namespace InheritanceExample
{
  internal class Program
  {
    private static void Main()
    {
      Rectangle rectangle = new()
      {
        Width = 2,
        Height = 4,
      };

      Circle circle = new()
      {
        Color = "Blue",
        Radius = 1,
      };

      rectangle.CalculateArea();
      circle.CalculateArea();
    }
  }
}