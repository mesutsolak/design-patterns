var builder = WebApplication.CreateBuilder(args);
 
builder.Services.AddControllers();
builder.Services.AddBasicCqrs();
builder.Services.AddRepositories();

// Cqrs yapýsýnýn bulunduðu yerdeki herhangi bir sýnýfýn tipi gerekmektedir.
builder.Services.AddMediatR(typeof(GetByFilterQueryRequest));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
