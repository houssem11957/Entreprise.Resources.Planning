
using DataAccess.Entities.Security;
using DataAccess.Persistence.ApplicationDbContext;
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

			builder.Services.AddAuthorization(options =>
			{
				options.AddPolicy("Nice", new Microsoft.AspNetCore.Authorization.AuthorizationPolicy(new List<ClaimsAuthorizationRequirement>(), new List<string>()));
			});

			builder.Services.AddDbContext<ERPDbContext>(options =>
				options.UseSqlServer(builder.Configuration.GetConnectionString("defaultconnection")));

			builder.Services.AddIdentity<UserEntity, ErpRole>()
				.AddEntityFrameworkStores<ERPDbContext>()
				.AddDefaultTokenProviders();


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
