using System;

namespace lightingThree
{
  public class Couch : Furniture, ISeating
  {
     public string ComfortLevel { get; set; }
  }
}