using Blogger.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blogger.Data.Mappings
{
	public class CategoryMap : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.HasData(
				new Category()
				{
					Id = Guid.Parse("11E8B5EA-DABB-4B9B-A13E-9086ED9A54F1"),
					Name = "Asp.Net Core",
					CreatedBy = "Admin Test",
					CreatedDate = DateTime.Now,
					IsDeleted = false
				}, new Category()
				{
					Id = Guid.Parse("1FD6F712-CE03-4EAD-9C26-0FC2BA1DB6E4"),
					Name = "Visual Studio",
					CreatedBy = "Admin Test",
					CreatedDate = DateTime.Now,
					IsDeleted = false
				}
			);
		}
	}
}
