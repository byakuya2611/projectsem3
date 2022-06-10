using PJ3.Data;
using PJ3.Repo;
using PJ3.Service;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddTransient<IAccountService, AccountService>();
builder.Services.AddTransient<IAccommodationService, AccommodationService>();
builder.Services.AddTransient<ICountryService, CountryService>();
builder.Services.AddTransient<IContactService, ContactService>();
builder.Services.AddTransient<ITouristSpotService, TouristSpotService>();
builder.Services.AddTransient<IBookingService, BookingService>();
builder.Services.AddTransient<IPakageService, PakageService>();
builder.Services.AddTransient<IPaymentModeService, PaymentModeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
