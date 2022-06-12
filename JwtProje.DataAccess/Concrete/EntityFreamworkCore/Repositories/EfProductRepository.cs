using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using JwtProje.DataAccess.Concrete.EntityFrameworkCore.Context;
using JwtProje.DataAccess.Interfaces;
using JwtProje.Entities.Concrete;

namespace JwtProje.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfProductRepository : EfGenericRepository<Product>, IProductDal
    {
       
    }
}
