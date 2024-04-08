﻿using Entity.Entities.Abstract;

namespace Entity.Entities
{
    public class Order : BaseEntity
    {
        public Basket Basket { get; set; }
        public string OrderStatus { get; set; }
        public bool IsComplete { get; set; }
        public DateTime OrderCreatedDate { get; set; }
        public DateTime OrderUpdatedDate { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
