var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();

app.MapGet("/ourtestapi", () =>
{
    return new
    {
        Name = "Ray"
    };
});

app.Run();