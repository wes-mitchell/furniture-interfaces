using System;

namespace lightingThree
{
  public interface ISeating
  {
    string ComfortLevel { get; set; }

    void ComfortZone()
    {
      Console.WriteLine("You're seat got a comfort upgrade! $$$");
      ComfortLevel = "maximum coziness";
    }

  }
  public interface ITable
  {
    int SeatCapacity { get; set; }

    void addSeat()
    {
      SeatCapacity++;
    }
  }
}