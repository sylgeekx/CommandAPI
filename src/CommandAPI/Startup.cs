using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
<<<<<<< HEAD
using CommandAPI.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

=======
>>>>>>> parent of abdf87b... Add model and reposity
namespace CommandAPI
{
 public class Startup
 {
    public IConfiguration Configuration {get;}
 public Startup(IConfiguration configuration)
 {
 Configuration = configuration;
 } 
 public void ConfigureServices(IServiceCollection services)
 {
 services.AddDbContext<CommandContext>(opt => opt.UseNpgsql
 (Configuration.GetConnectionString("PostgreSqlConnection")));
 
 services.AddControllers();
 }
 public void Configure(IApplicationBuilder app,
IWebHostEnvironment env)
 {
 if (env.IsDevelopment())
 {
 app.UseDeveloperExceptionPage();
 }
 app.UseRouting();
 app.UseEndpoints(endpoints =>
 {
 
 endpoints.MapControllers();
 });
 }
 }
}