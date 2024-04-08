﻿using Entity.Entities.Abstract;

namespace Entity.Entities
{
    public class Option : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Discount> Discounts { get; set; }
    }
}