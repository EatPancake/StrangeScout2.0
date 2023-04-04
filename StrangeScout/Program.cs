using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StrangeScout.Data;
using Microsoft.AspNetCore.HttpOverrides;
using System.Net;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<StrangeScoutContext>(options =>
    options.UseSqlite("Data Source=StrangeScoutContext-8513e199-7def-4329-8d0f-1f297ddc90e8.db"));
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
   // app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
   // app.UseHsts();
//}

app.UseForwardedHeaders(new ForwardedHeadersOptions
{ 
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});


//app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
