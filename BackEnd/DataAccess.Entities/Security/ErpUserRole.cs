using Microsoft.AspNetCore.Identity;

namespace DataAccess.Entities.Security
{
	public class ErpUserRole: IdentityUserRole<int>
	{
		public virtual UserEntity User { get; set; }
		public virtual ErpRole Role { get; set; }
	}
}
