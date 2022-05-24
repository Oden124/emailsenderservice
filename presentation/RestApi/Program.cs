using EmailSenderService;
using EmailSenderService.Memory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Регистрирую зависимости
builder.Services.AddSingleton<IEmailService, EmailService>();
builder.Services.AddSingleton<IEmailRepository,EmailRepository>();
builder.Services.AddSingleton<IMailSender,FakeMailSender>();

//------------------------------------------------

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
