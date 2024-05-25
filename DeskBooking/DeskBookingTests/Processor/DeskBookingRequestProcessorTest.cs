using DeskBooking.Core.Domain;
using DeskBooking.Core.Processor;

namespace DeskBooking.Core
{
    public class DeskBookingRequestProcessorTest
    {
        [Fact]
        public void ShouldReturnDeskBookingResultWithRequestValue() {
            //Arrange
            var processor = new DeskBookingRequestProcessor();
            DeskBookingRequest deskBookingRequest = new DeskBookingRequest()
            {
                FirstName = "John",
                LastName = "Frox",
                Email = "john.frox@gmail.com",
                BookingDate = DateTime.Now
            };

            //Act
            var deskBookingResult = processor.Book(deskBookingRequest);

            //Assert
            Assert.NotNull(deskBookingResult);
            Assert.Equal(deskBookingResult.FirstName, deskBookingRequest.FirstName);
            Assert.Equal(deskBookingResult.LastName, deskBookingRequest.LastName);
            Assert.Equal(deskBookingResult.Email, deskBookingRequest.Email);
            Assert.Equal(deskBookingResult.BookingDate, deskBookingRequest.BookingDate);
        }
    }
}
