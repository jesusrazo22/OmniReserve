using OmniReserve.Application;
using OmniReserve.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Agregar el servicio generador de Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); 

//Extensión para inyectar las dependencias de otras capas
builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Middleware restantes 
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();


app.Run();
