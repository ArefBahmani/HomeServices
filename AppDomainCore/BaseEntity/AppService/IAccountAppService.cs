using AppDomainCore.BaseEntity.Dto;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.BaseEntity.AppService
{
    public interface IAccountAppService
    {
        Task<List<IdentityError>> Register(AccountRegisterDto accountRegisterDto);
        Task<bool> Login(string Email,string password,CancellationToken cancellationToken );
        Task<List<IdentityError>> AdminRegister(AccountAdminRegisterDto accountAdminRegisterDto);
    }
}
