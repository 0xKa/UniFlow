using DataAccess.Interfaces;
using DataAccess.Repositories;
using BusinessLogic.Interfaces;
using BusinessLogic.Services;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection"); // from appsettings.json

// Register DAL
builder.Services.AddScoped<IPersonRepository>(provider => new PersonRepository(connectionString ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.")));

// Register BLL
builder.Services.AddScoped<IPersonService, PersonService>();


// Add services to the container.
builder.Services.AddControllers();

// Add Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Enable Swagger middleware
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();