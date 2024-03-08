using TaskOne.services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add controllers
builder.Services.AddControllers();


// builder.Services.AddTransient<ITodoRepository, TodoService>();

// new object is created per request
builder.Services.AddScoped<ITodoRepository, TodoService>(); // interface, class

// new object is created once per application
// builder.Services.AddSingleton<>();

// new object is created every time it is requested
// builder.Services.AddTransient<>(); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Add controller routing
app.MapControllers();

// Map additional routes if needed

app.Run();