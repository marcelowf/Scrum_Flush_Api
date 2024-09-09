using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using ScrumFlush.Infrastructure.Context;
using ScrumFlush.Infrastructure.CrossCutting.IOC;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new ModuleIOC());
});

builder.Services.AddCors(o => o.AddPolicy(name: "MyPolicy", builder =>
{
    builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
}));

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

app.UseCors("MyPolicy");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
//app.UseAuthentication(); 
//app.UseAuthorization();
app.MapControllers();
app.Run();
