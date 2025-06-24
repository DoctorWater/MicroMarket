namespace UserService.Domain.ValueObjects;

public record Name
{
    public string FirstName { get; }
    public string LastName { get; }

    public Name(string firstName, string lastName)
    {
        ValidateLastName(lastName);
        LastName = lastName;
        ValidateFirstName(firstName);
        FirstName = firstName;
    }
    
    private void ValidateFirstName(string firstName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
            throw new ArgumentNullException(nameof(firstName), "First name is required");
    }

    private void ValidateLastName(string lastName)
    {
        if (string.IsNullOrWhiteSpace(lastName))
            throw new ArgumentNullException(nameof(lastName), "Last name is required");
    }
}

