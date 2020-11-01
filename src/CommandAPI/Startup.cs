using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CommandAPI.Data;

namespace CommandAPI
{
 public class Startup
 {
 public void ConfigureServices(IServiceCollection services)
 {
 
 services.AddControllers();

 services.AddScoped<ICommandAPIRepo, MockCommandAPIRepo>();

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