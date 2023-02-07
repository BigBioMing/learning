using HttpClientDemo.HttpExtensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddSingleton<RequestIdDelegatingHandler>();
builder.Services.AddHttpClient<IMyCustomTypeHttpClient, MyCustomTypeHttpClient>()
    .SetHandlerLifetime(TimeSpan.FromMinutes(3))
    .ConfigureHttpClient(configureClient => configureClient.BaseAddress = new Uri("https://localhost:19283"))
    .AddHttpMessageHandler<RequestIdDelegatingHandler>();

builder.Services.AddSingleton<RequestIdDelegatingHandler2>();
builder.Services.AddHttpClient<IMyCustomTypeHttpClient2, MyCustomTypeHttpClient2>()
    .SetHandlerLifetime(TimeSpan.FromMinutes(5))
    .ConfigureHttpClient(configureClient => configureClient.BaseAddress = new Uri("https://localhost:19333"))
    .AddHttpMessageHandler<RequestIdDelegatingHandler2>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
