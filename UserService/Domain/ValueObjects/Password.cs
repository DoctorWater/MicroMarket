namespace UserService.Domain.ValueObjects;

public record Password
{
    public string PasswordHash { get; }

    public Password(string passwordHash)
    {
        ValidatePassword(passwordHash);
        PasswordHash = passwordHash;
    }

    private void ValidatePassword(string passwordHash)
    {
        if (string.IsNullOrWhiteSpace(passwordHash))
            throw new ArgumentNullException(nameof(passwordHash), "Password hash is required");
    }
}