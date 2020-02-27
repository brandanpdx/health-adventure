namespace Model
{
  public class Game
  {
    public static int Energy { get; set; } = 5;
    public static bool IsDead()
    {
      if(Energy <= 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static bool Won()
    {
      if(Energy >= 10)
      {
        return true;
      }
      return false;
    }
  }
}