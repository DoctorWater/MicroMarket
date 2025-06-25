namespace UserService.Domain.ValueObjects;

public record Password
{
    public string PasswordHash { get; }

    private Password(string passwordHash)
    {
        ValidatePassword(passwordHash);
        PasswordHash = passwordHash;
    }
    
    public static Password Create(string passwordHash) => new(passwordHash);

    private void ValidatePassword(string passwordHash)
    {
        if (string.IsNullOrWhiteSpace(passwordHash))
            throw new ArgumentNullException(nameof(passwordHash), "Password hash is required");
    }
}