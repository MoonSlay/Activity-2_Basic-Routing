var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "Add",
    pattern: "operation/Add/{num1:int}/{num2:int}",
    defaults: new { controller = "Operation", action = "Add" });

app.MapControllerRoute(
    name: "Subtract",
    pattern: "operation/Subtract/{num1:int}/{num2:int}",
    defaults: new { controller = "Operation", action = "Subtract" });

app.MapControllerRoute(
    name: "Multiply",
    pattern: "operation/Multiply/{num1:int}/{num2:int}",
    defaults: new { controller = "Operation", action = "Multiply" });

app.MapControllerRoute(
    name: "Divide",
    pattern: "operation/Divide/{num1:float}/{num2:float}",
    defaults: new { controller = "Operation", action = "Divide" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
