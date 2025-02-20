using AppDomainCore.UserEntite.Data;
using AppDomainCore.UserEntite.Dtos.CustomerDtos;
using AppDomainCore.UserEntite.Entiteies;
using AppDomainCore.UserEntite.Service.CustomerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.Service.UserEntite
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<bool> Add(CustomerCreateDto customer, CancellationToken cancellation)
        {
           return await _customerRepository.Add(customer, cancellation);
        }

        public async Task<bool> Delete(int customerId, CancellationToken cancellation)
        {
            return await _customerRepository.Delete(customerId, cancellation);
        }

        public async Task<bool> Edit(int CustomerId, CustomerUpdateDto customer, CancellationToken cancellation)
        {
            return await _customerRepository.Edit(CustomerId, customer, cancellation);
        }

        public async Task<List<Customer>> GetAll(CancellationToken cancellation)
        {
            return await _customerRepository.GetAll(cancellation);
        }

        public async Task<Customer> GetById(int CustomerId, CancellationToken cancellation)
        {
            return await _customerRepository.GetById(CustomerId, cancellation);
        }
    }
}
