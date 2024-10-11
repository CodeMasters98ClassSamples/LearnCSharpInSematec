using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBackend.Entities.AbstractClasses;

public abstract class CreateableEntity
{
    public DateTime CreatedAt { get; set; }
    public int CreatedByUserId { get; set; }
}
