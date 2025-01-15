using Microsoft.AspNetCore.Identity;

namespace DataAccess.Entities.Security
{
	public class ErpRole: IdentityRole<int>
	{
		public ICollection<ErpUserRole> UserRoles { get; set; }

	}
}
