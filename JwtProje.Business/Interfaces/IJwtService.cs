using System;
using System.Collections.Generic;
using System.Text;
using JwtProje.Entities.Concrete;

namespace JwtProje.Business.Interfaces
{
    public interface IJwtService
    {
        string GenerateJwt(AppUser appUser, List<AppRole> roles);
    }
}
