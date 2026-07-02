namespace GymManager.Domain.Common;


public abstract class BaseEntity
{
    public Guid Id { get;  }

    protected BaseEntity()
    {
        Id = GenerateId(); 
    }

    private static Guid GenerateId()
    {
        return Guid.NewGuid();
    }
}