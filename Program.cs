using Microsoft.EntityFrameworkCore;
using KHanERP.Data;
using AutoMapper;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add Entity Framework Core with SQL Server
builder.Services.AddDbContext<KHanERPDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//var config = new MapperConfiguration(cfg =>
//{
//    cfg.AddProfile<CustomerProfile>();
//});

//IMapper mapper = config.CreateMapper();


// CORS: Allow All
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
});

var app = builder.Build();

// Use CORS globally
app.UseCors("AllowAll");

// Enable Swagger
if (app.Environment.IsDevelopment() || app.Environment.IsStaging() || app.Environment.IsProduction()) // For all
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "KHanX ERP API V1");
        c.RoutePrefix = string.Empty; // Swagger UI on root URL
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
