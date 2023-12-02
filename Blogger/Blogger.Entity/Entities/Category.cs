using Blogger.Core.Entities;

namespace Blogger.Entity.Entities
{
	public class Category : EntityBase
	{
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
