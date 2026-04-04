
namespace Domain.ValueObjects;

public class TopicId
{
    public Guid Value { get; }

    public TopicId(Guid value)
    {
        this.Value = value;
    }

    public static TopicId Of(Guid value)
    {
        if (value == Guid.Empty)
            throw new DomainException("TopicId не может быть пустым.");

        return new TopicId(value);
    }

}
