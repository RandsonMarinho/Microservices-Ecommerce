using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// adiciona ocelot.json à configuração
builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);

// adiciona serviços Ocelot
builder.Services.AddOcelot(builder.Configuration);

var app = builder.Build();

await app.UseOcelot();

app.Run();
