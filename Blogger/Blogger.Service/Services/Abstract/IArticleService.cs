﻿using Blogger.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.Service.Services.Abstract
{
	public interface IArticleService
	{
		Task<List<Article>> GetAllArticlesAsync();
	}
}
