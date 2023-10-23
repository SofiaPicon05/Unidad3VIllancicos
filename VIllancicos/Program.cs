using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Villancicos.Models;
using VIllancicos.Repositories;

var builder = WebApplication.CreateBuilder(args);


//Registrar el contexto como servicio para que pueda ser inyectado
builder.Services.AddDbContext<villancicosContext>(
    optionsBuilder=>
    optionsBuilder.UseMySql("server=localhost; user id=root; password=root; database=villancicos", 
    ServerVersion.AutoDetect("server=localhost; user id=root; password=root; database=villancicos"))
    );


builder.Services.AddTransient<VillancicoRepository>();



builder.Services.AddMvc();

var app = builder.Build();


app.UseStaticFiles();
app.MapDefaultControllerRoute();

app.Run();
