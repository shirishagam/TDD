
using DeskBooking.Core.Domain;

namespace DeskBooking.Core.Processor;

public class DeskBookingRequestProcessor
{
    public DeskBookingRequestProcessor()
    {
    }

    public DeskBookingResult Book(DeskBookingRequest deskBookingRequest)
    {
        return new DeskBookingResult()
        {
            FirstName = deskBookingRequest.FirstName,
            LastName = deskBookingRequest.LastName,
            Email = deskBookingRequest.Email,
            BookingDate = deskBookingRequest.BookingDate
        };
    }
}