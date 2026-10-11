namespace OmniReserve.Domain.Exceptions;

public class RoomNotAvailableException : DomainException
{
    public RoomNotAvailableException(string roomNumber) 
        : base($"La habitación con número {roomNumber} no se encuentra disponible para reservar.")
    {
        
    }
}

