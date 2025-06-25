namespace UserService.Domain.ValueObjects;

public record Email
{
    public string EmailAddress { get; }

    private Email(string emailAddress)
    {
        EmailAddress = emailAddress;
        ValidateEmail(emailAddress);
    }
    
    public static Email Create(string emailAddress) => new(emailAddress);

    private void ValidateEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentNullException(nameof(email));
        
        try
        {
            _ =new System.Net.Mail.MailAddress(email);
        }
        catch
        {
            throw new ArgumentException("Invalid email address");
        }
    }
}