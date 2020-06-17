using GerenciamentoDeLojaPI.Context;
using GerenciamentoDeLojaPI.Interfaces;
using GerenciamentoDeLojaPI.Models;
using GerenciamentoDeLojaPI.Repositories;
using GerenciamentoDeLojaPI.UoW;
using Microsoft.Extensions.DependencyInjection;

namespace GerenciamentoDeLojaPI.Configuration
{
    public static class AplicationConfig
    {
        public static void AddApplicationSetup(this IServiceCollection services)
        {
            services.AddScoped<ICrudRepository<FuncionarioModel>, CrudRepository<FuncionarioModel>>();
            services.AddScoped<ICrudRepository<CargoModel>, CrudRepository<CargoModel>>();
            services.AddScoped<ICrudRepository<FornecedorModel>, CrudRepository<FornecedorModel>>();
            services.AddScoped<ICrudRepository<MarcaModel>, CrudRepository<MarcaModel>>();
            services.AddScoped<ICrudRepository<ProdutoModel>, CrudRepository<ProdutoModel>>();
            services.AddScoped<ICrudRepository<SetorModel>, CrudRepository<SetorModel>>();
            services.AddScoped<ICrudRepository<TipoModel>, CrudRepository<TipoModel>>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<SqlContext>();
        }
    }
}
