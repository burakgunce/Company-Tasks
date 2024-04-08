using Entity.Entities.Abstract;

namespace Entity.Entities
{
    public class Discount : BaseEntity
    {
        public Option Option { get; set; }
        public decimal DiscountRate { get; set; }
    }
}
