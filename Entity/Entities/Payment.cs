using Entity.Entities.Abstract;

namespace Entity.Entities
{
    public class Payment : BaseEntity
    {
        public Order Order { get; set; }
        public string NameLastName { get; set; }
        public string CreditCartNumber { get; set; }
        public string ExpireDate { get; set; }
        public string CVV { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsPaymentSuccess { get; set; }
    }
}
