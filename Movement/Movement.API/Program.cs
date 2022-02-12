using Movement.DAL.SQLServer.Depots;
using Movement.Services.DepotInterfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IDepotActionFeu, DepotActionFeu>();
builder.Services.AddScoped<IDepotBorne, DepotBorne>();
builder.Services.AddScoped<IDepotEvenement, DepotEvenement>();
builder.Services.AddScoped<IDepotIntersection, DepotIntersection>();
builder.Services.AddScoped<IDepotTraversePieton, DepotTraversePieton>();
builder.Services.AddScoped<IDepotTypeTransport, DepotTypeTransport>();
builder.Services.AddScoped<IDepotTypeUtilisateur, DepotTypeUtilisateur>();
builder.Services.AddScoped<IDepotUtilisateur, DepotUtilisateur>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
