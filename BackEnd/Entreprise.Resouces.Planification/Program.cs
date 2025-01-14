
using DataAccess.Entities.Security;
using DataAccess.Persistence.ApplicationDbContext;
using DataAccess.Persistence.Security.UserDbContext;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Entreprise.Resouces.Planification
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			// config  authentication
			builder.Services.AddAuthentication().AddBearerToken(IdentityConstants.BearerScheme, tokenOptions =>
			{
				tokenOptions.BearerTokenExpiration = TimeSpan.FromHours(24);
				tokenOptions.ClaimsIssuer = "localhost";
				tokenOptions.RefreshTokenExpiration = TimeSpan.FromHours(12);
				tokenOptions.TimeProvider = TimeProvider.System;
				tokenOptions.Validate();
			});

			builder.Services.AddAuthorization( options => {
				options.AddPolicy("Nice",new Microsoft.AspNetCore.Authorization.AuthorizationPolicy(new List<ClaimsAuthorizationRequirement>(),new List<string>()));
			});

			//builder.Services.
			builder.Services.AddDbContext<ERPDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("defaultconnection")));
			builder.Services.AddDbContext<SecurityDbContext>(X => X.UseSqlServer(builder.Configuration.GetConnectionString("Identityconnection")));

			builder.Services.AddIdentityCore<UserEntity>()
				.AddEntityFrameworkStores<SecurityDbContext>()
				.AddRoleManager<RoleManager<IdentityRole>>()
				.AddSignInManager<SignInManager<UserEntity>>()
				.AddUserManager<UserManager<UserEntity>>()
				.AddApiEndpoints();


			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if(app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}
