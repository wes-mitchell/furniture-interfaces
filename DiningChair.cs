using System;

namespace lightingThree
{
  public class DiningChair : Furniture, ISeating
  { 
    public string ComfortLevel { get; set; }
  }
}