namespace OmniReserve.Domain.Exceptions;

public class InvalidReservationDatesException : DomainException
{
    public InvalidReservationDatesException() 
        : base("La fecha del check-out debe ser posterior a la fecha del check-in.")
    {
        
    }
}