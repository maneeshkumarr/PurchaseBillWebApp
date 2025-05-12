using Microsoft.EntityFrameworkCore;
using PurchaseBillWebApp.Models;

var builder = WebApplication.CreateBuilder(args);

// ✅ Register the DbContext before building the app
builder.Services.AddDbContext<PurchaseContext>(options =>
    options.UseSqlite("Data Source=app.db"));

// ✅ Add Razor Pages support
builder.Services.AddRazorPages();

var app = builder.Build();

// ✅ Configure HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();
app.Run();
