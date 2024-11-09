using DAOs;
using Repositories;
using Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddScoped<IFlowerRepository, FlowerRepository>();

builder.Services.AddHttpClient<FlowerDAO>(client =>
{
    client.BaseAddress = new Uri("https://services.isolutions.top/api/v1/");
});

builder.Services.AddScoped<IFlowerService, FlowerService>();

builder.Services.AddScoped<FlowerDAO, FlowerDAO>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
