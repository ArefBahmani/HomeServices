﻿using AppDomainCore.BaseEntity.Service;
using AppDomainCore.UserEntite.AppService.CustomerAppService;
using AppDomainCore.UserEntite.Dtos.AdminDtos;
using AppDomainCore.UserEntite.Dtos.CustomerDtos;
using AppDomainCore.UserEntite.Entiteies;
using AppDomainCore.UserEntite.Service.CustomerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppDomain.AppService.UserEntite
{
    public class CustomerAppService : ICustomerAppService
    {
        private readonly IBaseService _baseSevices;
        private readonly ICustomerService _customerService;
        public CustomerAppService(ICustomerService customerService, IBaseService baseService)
        {
            _customerService = customerService;
            _baseSevices = baseService;
        }

        public async Task<bool> Add(CustomerCreateDto customer, CancellationToken cancellation)
        {
            customer.Image = await _baseSevices.UploadImage("Customer", customer.ProfileImgFile!, cancellation);
            return await _customerService.Add(customer, cancellation);
        }
        public async Task<bool> Delete(int customerId, CancellationToken cancellation)
        {
           return await _customerService.Delete(customerId, cancellation);
        }

        public async Task<bool> Edit(int CustomerId, CustomerUpdateDto customer, CancellationToken cancellation)
        {
            return await _customerService.Edit(CustomerId, customer, cancellation);
        }

        public async Task<List<Customer>> GetAll(CancellationToken cancellation)
        {
            return await _customerService.GetAll(cancellation);
        }

        public async Task<Customer> GetById(int CustomerId, CancellationToken cancellation)
        {
            return await _customerService.GetById(CustomerId, cancellation);
        }
    }
}
