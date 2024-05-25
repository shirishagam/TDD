namespace DeskBooking.Core.Domain;

public class DeskBookingBase
{
    public DateTime BookingDate { get; set; }
    public string Email { get; set; }

    public string FirstName { get; set; }
    public string LastName { get; set; }
}