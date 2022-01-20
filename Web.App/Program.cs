using Web.Lib;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/person", () => {
    var person = new Person("mali");
    return $"hello {person.Name}";

});

app.Run();
