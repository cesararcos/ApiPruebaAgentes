using ApiPruebaAgentes.Application;
using ApiPruebaAgentes.Application.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IGetMediaAppService, GetMediaAppService>();
builder.Services.AddTransient<IGetMedianaAppService, GetMedianaAppService>();
builder.Services.AddTransient<IGetStairAppService, GetStairAppService>();
builder.Services.AddTransient<IGetStairInvAppService, GetStairInvAppService>();
builder.Services.AddTransient<IGetRomboAppService, GetRomboAppService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
