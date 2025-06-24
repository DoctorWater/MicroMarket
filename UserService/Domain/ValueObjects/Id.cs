namespace UserService.Domain.ValueObjects;

public record Id
{
    public Guid Value { get; }

    public Id(Guid value)
    {
        ValidateId(value);
        Value = value;
    }
    
    private void ValidateId(Guid id)
    {
        if (id == Guid.Empty)
            throw new ArgumentNullException(nameof(id));
    }
}