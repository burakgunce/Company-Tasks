using Entity.Entities.Abstract;

namespace Entity.Entities
{
    public class Comment : BaseEntity
    {
        public ICollection<Product> Products { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public DateTime WriteDate { get; set; }
    }
}
