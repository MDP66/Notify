
var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureApplicationInbox(builder.Configuration);
builder.Services.ConfigureMediatR();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();