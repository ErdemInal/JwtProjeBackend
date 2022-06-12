using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using JwtProje.Business.Interfaces;
using JwtProje.DataAccess.Interfaces;
using JwtProje.Entities.Concrete;

namespace JwtProje.Business.Concrete
{
    public class ProductManager : GenericManager<Product>, IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IGenericDal<Product> genericDal,
            IProductDal productDal) : base(genericDal)
        {
            _productDal = productDal;
        }

       

    }
}
