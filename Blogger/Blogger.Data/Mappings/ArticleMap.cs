using Blogger.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blogger.Data.Mappings
{
	public class ArticleMap : IEntityTypeConfiguration<Article>
	{
		public void Configure(EntityTypeBuilder<Article> builder)
		{
			builder.HasData(new Article()
			{
				Id = Guid.NewGuid(),
				Title = "Asp.Net Core deneme makalesi",
				Content = "Asp.Net Core Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
				ViewCount = 15,
				CategoryId = Guid.Parse("11E8B5EA-DABB-4B9B-A13E-9086ED9A54F1"),				
				ImageId = Guid.Parse("85A153DC-B556-4E1A-AE32-3BF864ACEF76"),
				CreatedBy = "Admin test",
				CreatedDate = DateTime.Now,
				IsDeleted = false
			},
			new Article()
			{
				Id = Guid.NewGuid(),
				Title = "Visual Studio deneme makalesi",
				Content = "Visual Studio Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
				ViewCount = 15,
				CategoryId = Guid.Parse("1FD6F712-CE03-4EAD-9C26-0FC2BA1DB6E4"),
				ImageId = Guid.Parse("34714A6C-561B-400F-8271-54CEB82DBCAC"),
				CreatedBy = "Admin test",
				CreatedDate = DateTime.Now,
				IsDeleted = false
			}
			);
		}
	}
}
