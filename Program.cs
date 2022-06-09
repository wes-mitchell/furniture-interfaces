using System;
using System.Collections.Generic;

namespace lightingThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Loveseat cozy = new Loveseat
            {
                ComfortLevel = "Not Bad"
            };

            DiningChair crickety = new DiningChair
            {
                ComfortLevel = "terrible"
            };

            Couch okCouch = new Couch
            {
                ComfortLevel = "Good"
            };

            List<ISeating> seatList = new List<ISeating>();
            seatList.Add(cozy);
            seatList.Add(crickety);
            seatList.Add(okCouch);

            // foreach(ISeating seat in seatList)
            // {
            //     seat.ComfortZone();
            // }

            DiningTable thisTable = new DiningTable
            {
                SeatCapacity = 6
            };
            Nightstand bedSide = new Nightstand
            {
                SeatCapacity = 0
            };

            List<ITable> tableList = new List<ITable>();
            tableList.Add(thisTable);
            tableList.Add(bedSide);

            // foreach(ITable table in tableList)
            // {
            //     table.addSeat();
            //     Console.WriteLine($"{table.SeatCapacity}");
            // }

            List<Furniture> furnList = new List<Furniture>
            {
                cozy, crickety, okCouch, thisTable, bedSide
            };

            foreach(Furniture item in furnList)
            {
                if (item is ISeating seatObj)
                {
                    seatObj.ComfortZone();
                }
                else if (item is ITable tableObj)
                {
                    tableObj.addSeat();
                }
            }

            // check to see if previous for each loop works
            foreach(ITable table in tableList)
            {
                Console.WriteLine($"{table.SeatCapacity}");
            }
            foreach(ISeating seat in seatList)
            {
                Console.WriteLine($"{seat.ComfortLevel}");
            }
            
           


        }
    }
}

//  Exercise for this morning:
// Create a Furniture class, with some properties you think it would be helpful to have on such a class

// Create Couch, Loveseat, Nightstand, DiningTable, and DiningChair classes that inherit from Furniture and implement their own properties

//  Create interfaces called ISeating and ITable to describe type of furniture that are either seating or tables

// Have the appropriate classes you created in step 2 implement the interfaces you created in step 4

// In your Main method, create a list of ISeating and add instances of each of the classes that implements that interface to the list

// Do the same for ITable

// Iterate through each list, and call a method or write out a property value that is specific to each interface (ie, for seating, you might have a Reupholster method, or for tables a ReplaceLegs method... but those are just examples)

// Take all the instances of the classes from step two, and put them in a List of Furniture

// Do the same thing with this List as you did in Step 7 for the other two lists
