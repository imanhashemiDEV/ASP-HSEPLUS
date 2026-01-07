using HSEPLUS.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Add services to the container.
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

//builder.Services.AddIdentity<IdentityUser, IdentityRole>()
//    .AddDefaultTokenProviders()
//    .AddEntityFrameworkStores<ApplicationDbContext>();

//builder.Services.ConfigureApplicationCookie(options =>
//{
//    options.LoginPath = "/Login";
//    options.LogoutPath = "/Logout";
//    options.AccessDeniedPath = "/AccessDenied";
//});


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
