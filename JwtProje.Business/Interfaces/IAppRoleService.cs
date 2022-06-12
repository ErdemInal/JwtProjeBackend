using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using JwtProje.Entities.Concrete;

namespace JwtProje.Business.Interfaces
{
    public interface IAppRoleService : IGenericService<AppRole>
    {
        Task<AppRole> FindByName(string roleName);
    }
}
