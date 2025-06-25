namespace UserService.Domain.ValueObjects;

public record Role 
{
    public RolesEnum Value { get; }
    
    private Role(RolesEnum role)
    {
        ValidateRole(role);
        Value = role;
    }
    
    public static Role Create(RolesEnum role) => new(role);
    
    private void ValidateRole(RolesEnum role)
    {
        if (role == RolesEnum.None) 
            throw new ArgumentException("Role cannot be None");
    }
}

public enum RolesEnum
{
    None = 0,
    Admin = 1,
    User = 2
}