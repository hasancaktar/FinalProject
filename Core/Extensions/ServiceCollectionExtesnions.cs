using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Extensions
{
    public  static class ServiceCollectionExtesnions
    {
        //ASP.net yani api'nin servis bağımlılıklarını eklediğimiz ya da araya girmesini istediğimiz servisleri eklediğim yer
        //Buradaki "this" neyi genişletmek isteiğimizi belirttiriğimiz anlamına geliyor.
        public static IServiceCollection AddDependencyResolves(this IServiceCollection serviceCollection, ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(serviceCollection);
            }

            return ServiceTool.Create(serviceCollection);
        }
    }

}
