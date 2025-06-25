namespace MicroMarket.Contacts.User;

public record UserCreated 
(
    Guid     UserId,
    string   Email,
    string   FirstName,
    string   LastName,
    DateTime CreatedAtUtc
);