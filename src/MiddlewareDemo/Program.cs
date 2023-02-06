using Microsoft.AspNetCore.Http;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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

//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("hello");
//    await next();
//    await context.Response.WriteAsync("hello 2");
//});

//app.Map("/abc", appBuilder =>
//{
//    appBuilder.Use(async (context, next) =>
//    {
//        await context.Response.WriteAsync("abc ǰ ");
//        await next();
//        await context.Response.WriteAsync("abc �� ");
//    });
//});

app.MapWhen(httpContext =>
{
    return httpContext.Request.Path.Value?.Contains("aka") == true;
}, appBuilder =>
{
    //appBuilder.Use(async (context, next) =>
    //{
    //    await context.Response.WriteAsync("aka ǰ ");
    //    await next();
    //    await context.Response.WriteAsync("aka �� ");
    //});
    appBuilder.Run(async context =>
    {
        await context.Response.WriteAsync("aka 2 ǰ ");
        await context.Response.WriteAsync("aka 2 �� ");
    });
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
