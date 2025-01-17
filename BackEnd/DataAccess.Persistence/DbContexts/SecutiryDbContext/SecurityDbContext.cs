using DataAccess.Entities.Security;
using DataAccess.Persistence.DbContexts.DbContextSetting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DataAccess.Persistence.DbContexts.SecutiryDbContext
{
	public  class SecurityDbContext : 
		Microsoft.AspNetCore.Identity.EntityFrameworkCore.
		IdentityDbContext<UserEntity, ErpUserRole, int, 
			IdentityUserClaim<int>, IdentityUserRole<int>, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
	{
		public SecurityDbContext(DbContextOptions<SecurityDbContext> options ) : base(options)
		{
			
		}
		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			// config user table
			builder.ApplyUserTableConfigurations();
		}
		DbSet<UserEntity> Users { get; set; }
	}
}
