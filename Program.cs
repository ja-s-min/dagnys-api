using Microsoft.EntityFrameworkCore;
using dagnys_api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<dagnys_api.Data.DataContext>(options =>{
    options.UseSqlite(builder.Configuration.GetConnectionString("DevConnection"));
});

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
