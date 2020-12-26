using System;
using System.Linq.Expressions;
using Core.Entities;
using Core.Specification;

namespace Core.Specifications
{
  public class ProductWithBrandsAndTypesSpecification : BaseSpecification<Product>
  {
    public ProductWithBrandsAndTypesSpecification()
    {
      AddInclude(x => x.ProductType);
      AddInclude(x => x.ProductBrand);
    }

    public ProductWithBrandsAndTypesSpecification(int id) : base(x => x.Id == id)
    {
      AddInclude(x => x.ProductType);
      AddInclude(x => x.ProductBrand);
    }
  }
}