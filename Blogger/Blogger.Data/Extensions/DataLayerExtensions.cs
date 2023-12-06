using Blogger.Data.Repositories.Abstract;
using Blogger.Data.Repositories.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.Data.Extensions
{
	public static class DataLayerExtensions
	{
		public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
			return services;
		}
	}
}
