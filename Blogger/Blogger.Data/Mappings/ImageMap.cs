using Blogger.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blogger.Data.Mappings
{
	public class ImageMap : IEntityTypeConfiguration<Image>
	{
		public void Configure(EntityTypeBuilder<Image> builder)
		{
			builder.HasData(
				new Image()
				{
					Id = Guid.Parse("85A153DC-B556-4E1A-AE32-3BF864ACEF76"),
					FileName = "Images/testimage",
					FileType = "jpg",
					CreatedBy = "Admin test",
					CreatedDate = DateTime.Now,
					IsDeleted = false
				},
				new Image()
				{
					Id = Guid.Parse("34714A6C-561B-400F-8271-54CEB82DBCAC"),
					FileName = "Images/vstest",
					FileType = "png",
					CreatedBy = "Admin test",
					CreatedDate = DateTime.Now,
					IsDeleted = false
				}
				);
		}
	}
}
