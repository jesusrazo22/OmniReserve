using OmniReserve.Domain.Enums;

namespace OmniReserve.Domain.Entities;

public class User
{
    public Guid Id { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public string PasswordHash { get; private set; }
    public Role Role { get; private set; }

    public User(string firstName, string lastName, string email, string passwordHash, Role role)
    {
        Id = Guid.NewGuid();
        FirstName = string.IsNullOrWhiteSpace(firstName) ? throw new ArgumentNullException(nameof(firstName)) : firstName;
        LastName = string.IsNullOrWhiteSpace(lastName) ? throw new ArgumentNullException(nameof(lastName)) : lastName;
        Email = string.IsNullOrWhiteSpace(email) ? throw new ArgumentNullException(nameof(email)) : email;
        PasswordHash = string.IsNullOrWhiteSpace(passwordHash) ? throw new ArgumentNullException(nameof(passwordHash)) : passwordHash;
        Role = role;
    }
}