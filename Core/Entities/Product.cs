using System;

namespace Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; } 
        public int UnitID { get; set; }
        public decimal ProductAmount { get; set; }
        public decimal WholeSalePrice { get; set; }
        public decimal RetailPrice { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Boolean IsActive { get; set; }
        public Boolean IsDeleted { get; set; }
    }
}