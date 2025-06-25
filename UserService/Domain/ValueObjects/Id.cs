namespace UserService.Domain.ValueObjects;

public record Id
{
    public Guid Value { get; }

    private Id(Guid value)
    {
        ValidateId(value);
        Value = value;
    }
    
    public static Id New() => new(Guid.NewGuid());
    public static Id New(Guid id) => new(id);
    
    private void ValidateId(Guid id)
    {
        if (id == Guid.Empty)
            throw new ArgumentNullException(nameof(id));
    }
}