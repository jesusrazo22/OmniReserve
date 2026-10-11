using Microsoft.EntityFrameworkCore;
using OmniReserve.Application.Common.Interfaces;
using OmniReserve.Domain.Entities;

namespace OmniReserve.Infrastructure.Persistence.Repositories;

public class RoomRepository : IRoomRepository
{
    private readonly ApplicationDbContext _context;

    public RoomRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Room room)
    {
        // EF Core trackea la Entidad
        await _context.Rooms.AddAsync(room);
        
        // ¡Crucial! Confirma a la base de datos real
        await _context.SaveChangesAsync();
    }

    public async Task<Room?> GetByIdAsync(Guid id)
    {
        // Se conecta a PostgreSQL para obtener o retornar nulo
        return await _context.Rooms.FirstOrDefaultAsync(r => r.Id == id);
    }

    public async Task<Room?> SearchByNumberAsync(string roomNumber)
    {
        
        return await _context.Rooms.FirstOrDefaultAsync(r => r.RoomNumber == roomNumber);
    }
}