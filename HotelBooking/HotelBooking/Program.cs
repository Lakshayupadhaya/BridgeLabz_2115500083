using System;

class HotelBooking 
{
    //Declaring attributes guest name , room type, and nights for the booking
    private string guestName;
    private string roomType;
    private int nights; 
    //Constructors  for all the parameters
    public HotelBooking() 
    {
        this.guestName = "NA";
        this.roomType = "NA";
        this.nights = 0;
    }
    public HotelBooking(string guestName)
    {
        this.guestName = guestName;
        this.roomType = "NA";
        this.nights = 0;
    }

    public HotelBooking(string guestName, string roomType)
    {
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = 0;
    }
    public HotelBooking(string guestName, string roomType, int nights)
    {
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }
    // copy constructor
    public HotelBooking(HotelBooking booking) 
    {
        this.guestName = booking.guestName;
        this.roomType= booking.roomType;
        this.nights= booking.nights;
    }

    static void Main() 
    {
        HotelBooking book1 = new HotelBooking("Lakshay", "Suite", 4);//creating instance of booking class
        HotelBooking book2 = new HotelBooking(book1);//copying the values of book 1 using copy constructor

        Console.WriteLine(book1.guestName + " " + book1.roomType + " " + book1.nights);
        Console.WriteLine(book2.guestName + " " + book2.roomType + " " + book2.nights);
        
    }

}