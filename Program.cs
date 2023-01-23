using Blog.Data;
using Blog.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddControllers()
    .ConfigureApiBehaviorOptions(options =>
    {
        options.SuppressModelStateInvalidFilter = true;
    });
builder.Services.AddDbContext<BlogDataContext>();
builder.Services.AddTransient<TokenService>();//Sempre cria uma nova instância, não precisa de um Estado.
//builder.Services.AddScoped(); // Ele age por requisição, enquanto a requisição ele utilizará a mesma instância.
//uilder.Services.AddSingleton(); // Singleton => 1 por App!

var app = builder.Build();

app.MapControllers();
app.Run();
