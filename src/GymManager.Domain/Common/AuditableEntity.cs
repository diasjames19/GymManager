
namespace GymManager.Domain.Common;


public abstract class AuditableEntity : BaseEntity
{
    public DateTime CreatedAt { get;  }

    public String CreatedBy { get;  } = String.Empty;

    public DateTime? UpdatedAt { get;  }
    public String? UpdatedBy { get;  }


    protected AuditableEntity()
    {
        CreatedAt = GetDateTime();
       
    }

    private static DateTime GetDateTime()
    {
        return DateTime.UtcNow;
    }

    
}