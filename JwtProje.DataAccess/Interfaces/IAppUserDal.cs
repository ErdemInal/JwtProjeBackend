using System.Collections.Generic;
using System.Threading.Tasks;
using JwtProje.Entities.Concrete;

namespace JwtProje.DataAccess.Interfaces
{
    public interface IAppUserDal : IGenericDal<AppUser>
    {
        Task<List<AppRole>> GetRolesByUserName(string userName);
    }
}
