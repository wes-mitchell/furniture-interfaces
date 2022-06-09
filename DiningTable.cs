using System;

namespace lightingThree
{
  public class DiningTable : Furniture, ITable
  {
    public int SeatCapacity { get; set; }
  }
}