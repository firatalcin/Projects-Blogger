using Blogger.Service.Services.Abstract;
using Blogger.Service.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace Blogger.Service.Extensions
{
	public static class ServiceLayerExtensions
	{
		public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
		{
			services.AddScoped<IArticleService, ArticleService>();
			return services;
		}
	}
}
