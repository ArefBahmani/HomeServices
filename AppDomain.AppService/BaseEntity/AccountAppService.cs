﻿using AppDomainCore.BaseEntity.AppService;
using AppDomainCore.BaseEntity.Dto;
using AppDomainCore.UserEntite.Entiteies;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.AppService.BaseEntity
{
    public class AccountAppService : IAccountAppService
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        public AccountAppService(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
    {
        _signInManager = signInManager;
        _userManager = userManager;
    }
        public async Task<List<IdentityError>> AdminRegister(AccountAdminRegisterDto accountAdminRegisterDto)
        {
            var user = CreateUser();

            user.UserName = accountAdminRegisterDto.Email;
            user.Email = accountAdminRegisterDto.Email;

            user.Admin = new Admin()
            {
                FirstName = accountAdminRegisterDto.FirstName,
                LastName = accountAdminRegisterDto.LastName,
                Gender = accountAdminRegisterDto.Gender,
            };

            var result = await _userManager.CreateAsync(user, accountAdminRegisterDto.Password);

            var userAdminId = user.Admin!.Id;
            await _userManager.AddClaimAsync(user, new Claim("userAdminId", userAdminId.ToString()));

            if (result.Succeeded)
                await _userManager.AddToRoleAsync(user, "Admin");

            return (List<IdentityError>)result.Errors;
        }

        public async Task<bool> Login(string Email,string password, CancellationToken cancellationToken)
        {
            var result = await _signInManager.PasswordSignInAsync(Email, password, false, lockoutOnFailure: false);
            return result.Succeeded;
        }

        public async Task<List<IdentityError>> Register(AccountRegisterDto accountRegisterDto)
        {
            var role = string.Empty;

            var user = CreateUser();

            user.UserName = accountRegisterDto.Email;
            user.Email = accountRegisterDto.Email;

            if (accountRegisterDto.isExpert)
            {
                role = "Expert";
                user.Expert = new Expert()
                {
                    FirstName = accountRegisterDto.FirstName,
                    LastName = accountRegisterDto.LastName,
                    Gender = accountRegisterDto.Gender
                };
            }
            else
            {
                role = "Customer";
                user.Customer = new Customer()
                {
                    FirstName = accountRegisterDto.FirstName,
                    LastName = accountRegisterDto.LastName,
                    Gender = accountRegisterDto.Gender
                };
            }

            var result = await _userManager.CreateAsync(user, accountRegisterDto.Password);

            if (accountRegisterDto.isExpert)
            {

                var userExpertId = user.Expert!.Id;
                await _userManager.AddClaimAsync(user, new Claim("userExpertId", userExpertId.ToString()));
            }
            else
            {

                var userCustomerId = user.Customer!.Id;
                await _userManager.AddClaimAsync(user, new Claim("userCustomerId", userCustomerId.ToString()));
            }

            if (result.Succeeded)
                await _userManager.AddToRoleAsync(user, role);

            return (List<IdentityError>)result.Errors;
        }
        private ApplicationUser CreateUser()
        {
            try
            {
                return Activator.CreateInstance<ApplicationUser>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(ApplicationUser)}'. " +
                                                    $"Ensure that '{nameof(ApplicationUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                                                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }
    }
}
