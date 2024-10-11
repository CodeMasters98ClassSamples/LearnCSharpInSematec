using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBackend.Entities.AbstractClasses;

public abstract class DeleteableEntity
{
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
    public int DeletedByUserId { get; set; }
}
