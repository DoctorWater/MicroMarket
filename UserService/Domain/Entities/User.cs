using UserService.Domain.ValueObjects;

namespace UserService.Domain.Entities;

public class User
{
    public Id Id { get; private set; }
    public Name Name { get; private set; }
    public Email Email { get; private set; }
    public Password Password { get; private set; }
    public Role Role { get; private set; }

    public User(Id id, Name name, Email email, Password password, Role role)
    {
        Id = id;
        Name = name;
        Email = email;
        Password = password;
        Role = role;
    }
}