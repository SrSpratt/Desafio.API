using Desafio.API.Data;
using Desafio.API.AbstractModels;
using Desafio.API.Repositories;
using Microsoft.EntityFrameworkCore;
using System;

namespace Desafio.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            
            //adiciona os controladores
            builder.Services.AddControllers();


            //Isso eu não entendo muito bem, código automático
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //

            //Adicionar o modelo de conexão do entity framework
            builder.Services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));//linha de conexão com o banco
            });

            //adiciona os repositórios (no caso, O repositório)
            builder.Services.AddScoped<Inventory>();


            var app = builder.Build();


            //Isso eu também ainda não entendo, veio automático
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
        }
    }
}
