using System;

class Program
{
    static void Main(string[] args)
    {
        Event event1 = new Lecture("Corey Jacobson", 300);
        event1.getEvent("The Art of Calling Elk", "A beginners guide to calling elk", "Elk Calling Lecture", "July 25, 2023", "4:30 PM - 7:00 PM","Clark Church Building - 200 North 4300 East, Rigby, Idaho.");
        Console.WriteLine(event1.getShort());
        Console.WriteLine(event1.getStandard());
        Console.WriteLine(event1.getDetails());
        Console.WriteLine("Press enter to see the next event.");
        Console.ReadLine();
        Console.Clear();

        Event event2 = new Lecture("Fred Bear", 150);
        event2.getEvent("The Basics of Hunting with a Bow.", "Do's and Dont's of Archery Hunting", "Lecture", "June 22, 2023", "4:00PM - 6:00PM", "Ririe High School - Ririe, Idaho");
        Console.WriteLine(event2.getShort());
        Console.WriteLine(event2.getStandard());
        Console.WriteLine(event2.getDetails());
        Console.WriteLine("Press enter to see the next event.");
        Console.ReadLine();
        Console.Clear();

        Event event3 = new Reception("reserveyourspot@weddings.com");
        event3.getEvent("Reception of Jose and Georgina Espinoza", "Come celebrate the lovely couple!", "Wedding Reception", "April 16, 2023", "7:00 PM - 9:00 PM", "Twin Bridges - Ririe, Idaho" );
        Console.WriteLine(event3.getShort());
        Console.WriteLine(event3.getStandard());
        Console.WriteLine(event3.getDetails());
        Console.WriteLine("Press enter to see the next event.");
        Console.ReadLine();

        Event event4 = new Reception("RSVP@idadoreceptiosn.com");
        event4.getEvent("Reception for Sara Johnson and Dan Monson", "Please join us to celebrate the marriage of Dan and Sara", "Wedding Reception", "August 18, 2023", "5:00PM - 8:00PM", "White Barn - 135 West 500 South, Rexburg, Idaho");
        Console.WriteLine(event4.getShort());
        Console.WriteLine(event4.getStandard());
        Console.WriteLine(event4.getDetails());
        Console.WriteLine("Press enter to see the next event.");
        Console.ReadLine();

        Event event5 = new Outdoor("Sunny, slight northernwester wind, High: 67 - Low: 32");
        event5.getEvent("Community Antler Hunt", "Come spend time with the members of your community and try to find a few antlers as well!", "Shed Hunt", "Arpil 16, 2023", "7:00aM - 2:00", "Sand Dunes - St. Anthony, ID");
        Console.WriteLine(event5.getShort());
        Console.WriteLine(event5.getStandard());
        Console.WriteLine(event5.getDetails());
        Console.WriteLine("Press enter to see the next event.");
        Console.ReadLine();

        Event event6 = new Outdoor("35% chance of rain, High: 79 - Low 47");
        event6.getEvent("Ririe Bass Fishing Tournament", "Come join some of the best fisherman Idaho has to offer to see if you can win the prize!", "Outdoor Competition", "June, 9, 2023", "6:00 AM - 5:00 PM", "Ririe Reservior - Ririe, ID");        
        Console.WriteLine(event6.getShort());
        Console.WriteLine(event6.getStandard());
        Console.WriteLine(event6.getDetails());
        Console.WriteLine("Press enter to see the next event.");
        Console.ReadLine();

    }
}
