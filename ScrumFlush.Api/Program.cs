using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using ScrumFlush.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthorization();
builder.Services.AddControllers();
builder.Services.AddControllersWithViews();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(gen =>
{
    gen.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Scrum Flush Api",
        Version = "v1.00.00",
        Contact = new OpenApiContact
        {
            Name = "Scrum Flush",
            Email = "marcelowzorekfilho@gimal.com"
        }
    });
});

builder.Services.AddDbContext<SqlContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
    b => b.MigrationsAssembly("ScrumFlush.Infrastructure")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();
app.Run();
