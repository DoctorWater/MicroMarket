using UserService.Domain.ValueObjects;

namespace UserService.Domain.Entities;

public class User
{
    public Id Id { get; private set; }
    public Name Name { get; private set; }
    public Email Email { get; private set; }
    public Password Password { get; private set; }
    public Role Role { get; private set; }

    private User(Id id, Name name, Email email, Password password, Role role)
    {
        Id = id;
        Name = name;
        Email = email;
        Password = password;
        Role = role;
    }

    public static User Create(Email email, Name name, Password hash, Role role)
    {
        return new User(Id.New(), name, email, hash, role);
    }
    
    public static User Create(Guid id,Email email, Name name, Password hash, Role role)
    {
        return new User(Id.New(id), name, email, hash, role);
    }
}