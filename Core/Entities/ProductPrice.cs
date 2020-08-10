using System;

namespace Core.Entities
{
    public class ProductPrice : BaseEntity
    {
        public decimal WholeSalePrice { get; set; }
        public decimal RetailPrice { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Boolean IsActive { get; set; }
        public Boolean IsDeleted { get; set; }

        public int UnitId { get; set; }
        public Unit Unit { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        
    }
}