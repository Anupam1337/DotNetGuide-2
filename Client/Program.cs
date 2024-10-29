using CommonNew.Middleware;
using CommonNew.ORM;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<OrmFacadeService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<RequestValidationMiddleware>();
app.UseMiddleware<LoggingMiddleware>();
app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseMiddleware<ResponseFormattingMiddleware>();

app.UseRouting();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
