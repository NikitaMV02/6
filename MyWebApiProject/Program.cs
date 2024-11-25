var builder = WebApplication.CreateBuilder(args);

// Додати Swagger для Development
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddSwaggerGen();
}

builder.Services.AddControllers();

var app = builder.Build();

// Увімкнути Swagger для Development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();

app.Run();
