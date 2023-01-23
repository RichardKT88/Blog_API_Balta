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
builder.Services.AddTransient<TokenService>();//Sempre cria uma nova inst�ncia, n�o precisa de um Estado.
//builder.Services.AddScoped(); // Ele age por requisi��o, enquanto a requisi��o ele utilizar� a mesma inst�ncia.
//uilder.Services.AddSingleton(); // Singleton => 1 por App!

var app = builder.Build();

app.MapControllers();
app.Run();
