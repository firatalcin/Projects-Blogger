using AutoMapper;
using Blogger.Data.UnitOfWorks;
using Blogger.Entity.DTOs.Articles;
using Blogger.Entity.Entities;
using Blogger.Service.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.Service.Services.Concrete
{
	public class ArticleService : IArticleService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public ArticleService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public async Task<List<ArticleDto>> GetAllArticlesAsync()
		{
			var articles = await _unitOfWork.GetRepository<Article>().GetAllAsync();
			var map = _mapper.Map<List<ArticleDto>>(articles);
			return map;
		}
	}
}
