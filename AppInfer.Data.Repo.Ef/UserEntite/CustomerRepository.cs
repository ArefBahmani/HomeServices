using AppDomainCore.UserEntite.Data;
using AppDomainCore.UserEntite.Entiteies;
using AppInfer.Db.Sql.Ef.Dbase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInfer.Data.Repo.Ef.UserEntite
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _context;
        public CustomerRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public async Task<bool> Add(Customer customer, CancellationToken cancellation)
        {
            var model = new Customer()
            {
                
                CreatAt = DateTime.Now,
                PhoneNumber = customer.PhoneNumber,
                
            };
            await _context.AddAsync(model);
            await _context.SaveChangesAsync(cancellation);
            return true;
        }

        public async Task<bool> Delete(int customerId, CancellationToken cancellation)
        {
            var model = await _context.Customers.FirstOrDefaultAsync(x=> x.Id == customerId,cancellation);
            model.IsDeleted = true;
            await _context.SaveChangesAsync(cancellation);
            return true;
        }

        public async Task<bool> Edit(int CustomerId, Customer customer, CancellationToken cancellation)
        {
            var model = await _context.Customers.FirstOrDefaultAsync(x=> x.Id == CustomerId,cancellation);
            model = new Customer()
            {
                Address = customer.Address,
                Balance = customer.Balance,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                ImageProfile = customer.ImageProfile,
                UpdateAt = DateTime.Now,
            };
            await _context.AddAsync(model);
            await _context.SaveChangesAsync(cancellation);
            return true;
        }

        public async Task<List<Customer>> GetAll(CancellationToken cancellation)
        {
            var models = await _context.Customers.ToListAsync(cancellation);
            return models;
        }

        public async Task<Customer> GetById(int CustomerId, CancellationToken cancellation)
        {
            var model = await _context.Customers.AsNoTracking().FirstOrDefaultAsync( x=> x.Id == CustomerId, cancellation);
            return model;
        }
    }
}
