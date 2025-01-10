using DataAccess.Entities.Security;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Persistence.Security.UserDbContext
{
	public class SecurityDbContext : Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext<UserEntity>
	{
		public SecurityDbContext()
		{
		}
	}
}
