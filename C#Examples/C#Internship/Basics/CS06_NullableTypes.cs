using System;
class CS06_NullableTypes
{
     void Main()
    {
        int AvailableTickets;
        int? TicketsOnSale = null;

        if (TicketsOnSale == null)
        {
            AvailableTickets = 0;
        }
        else
        {
            AvailableTickets = (int)TicketsOnSale;
        }

        Console.WriteLine("Available Tickets={0}", AvailableTickets);

        // int AvailableTickets;
        // int? TicketsOnSale = null;

        //Using null coalesce operator ??
        // AvailableTickets = TicketsOnSale ?? 0;

        // Console.WriteLine("Available Tickets={0}", AvailableTickets);
    }

}