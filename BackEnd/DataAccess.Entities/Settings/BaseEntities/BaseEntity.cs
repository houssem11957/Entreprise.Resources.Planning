using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Settings.BaseEntities;
public  class BaseEntity
{
    public DateTime CreatedOn { get; private set; }
    public DateTime LastModified { get; private set; }
    public int LastModifiedBy { get;  set; }
    public int CreatedBy { get; private set; }

    public virtual void InitValues()
    {
        CreatedOn = DateTime.Now;
        LastModified = DateTime.Now;
        LastModifiedBy =-1;
        CreatedBy = -1;
    }
}
