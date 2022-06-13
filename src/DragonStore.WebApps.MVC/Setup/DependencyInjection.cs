using MediatR;
using DragonStore.Catalogo.Application.Services;
using DragonStore.Catalogo.Data;
using DragonStore.Catalogo.Data.Repository;
using DragonStore.Catalogo.Domain;
using DragonStore.Catalogo.Domain.Events;
using DragonStore.Core.Bus;

namespace DragonStore.WebApp.MVC.Setup
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            // Domain Bus (Mediator)
            services.AddSingleton<IMediatrHandler, MediatrHandler>();
        

            // Catalogo
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoAppService, ProdutoAppService>();
            services.AddScoped<IEstoqueService, EstoqueService>();


            services.AddScoped<INotificationHandler<ProdutoAbaixoEstoqueEvent>, ProdutoEventHandler>();
        }
    }
}