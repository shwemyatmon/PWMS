using Core.Entities;

namespace Core.Specifications
{
    public class ProductWithUnitSpecification : BaseSpecification<Product>
    {
        public ProductWithUnitSpecification(int id): base(o => o.Id == id)
        {
            //   AddInclude(o => o.Unit);
        }


    }
}