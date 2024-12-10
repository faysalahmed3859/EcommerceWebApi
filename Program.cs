var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();
if (app.Environment.IsDevelopment()){
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.MapGet("/",() =>
{
    return "Api is now work";
});
app.MapGet("/hello",() =>
{
    return "Get method From: Hello";
});
app.MapPost("/hello",() =>
{
    return "POST method From: Hello";
});
app.MapPut("/hello",() =>
{
    return "PUT method From: Hello";
});
app.MapDelete("/hello",() =>
{
    return "Delete method From: Hello";
});

app.Run();
