using AdminPanel.Business.DependencyResolvers.Autofac;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AdminPanel.Business.Abstract;
using AdminPanel.Business.Concrete;

public class Program
{
    public static void Main(string[] args)
    {


        var builder = Host.CreateDefaultBuilder(args);
        var Ibuilder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        Ibuilder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        Ibuilder.Services.AddEndpointsApiExplorer();
        Ibuilder.Services.AddSwaggerGen();
        Ibuilder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
        builder.ConfigureContainer<ContainerBuilder>(builder =>
        {
            builder.RegisterModule(new AutofacBusinessModule());
        });

        var app = Ibuilder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }

    //public static IHostBuilder CreateHostBuilder(string[] args) =>
    //Host.CreateDefaultBuilder(args)
    //.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    //.ConfigureContainer<ContainerBuilder>(builder =>
    //{
    //    builder.RegisterModule(
    //        new AutofacBusinessModule());
    //})
    //    .ConfigureWebHostDefaults(webBuilder =>
    //    {
    //        webBuilder.UseStartup<AutofacBusinessModule>();
    //    }//
}