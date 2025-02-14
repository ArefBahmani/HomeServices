using AppDomainCore.AddressEntitie.Data;
using AppDomainCore.AddressEntitie.Entite;
using AppInfer.Db.Sql.Ef.Dbase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInfer.Data.Repo.Ef.AddressEntite
{
    public class AddressRepository : IAddressRepository
    {
        private readonly AppDbContext _context;
        public AddressRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public async Task<bool> Creat(Address address, CancellationToken cancellationToken)
        {
            var newModel = new Address()
            {

                PostalCode = address.PostalCode,
                Province = address.Province,
                Street = address.Street,
                CreatAt = DateTime.Now,

            };
            if(newModel == null)
            {
                return false;
            }
            await _context.Addresses.AddAsync(newModel);
          await  _context.SaveChangesAsync(cancellationToken);
            return true;
            
        }

        public async Task<bool> Delete(int addressId, CancellationToken cancellationToken)
        {
            var target = await _context.Addresses.FirstOrDefaultAsync(x => x.Id == addressId, cancellationToken);
            if (target == null)
            {
                return false;
            }
            target.IsDeleted = true;
          await  _context.SaveChangesAsync(cancellationToken);
            return true;

        }

        public async Task<Address> GetAddressById(int addressId, CancellationToken cancellationToken)
        {
            var model = await _context.Addresses.AsNoTracking().FirstOrDefaultAsync(x => x.Id == addressId, cancellationToken);

            return model;

        }

        public async Task<List<Address>> GetAllAddresses(CancellationToken cancellationToken)
        {
           var models = await _context.Addresses.AsNoTracking().ToListAsync(cancellationToken);
            return models;
        }

        public async Task<bool> Update(int addressId,Address address, CancellationToken cancellationToken)
        {
            var model = await _context.Addresses.FirstOrDefaultAsync(x => x.Id == addressId, cancellationToken);
            model = new Address()
            {



                CreatAt = DateTime.Now,
                PostalCode = address.PostalCode,
                IsDeleted = false,
                ProvinceId = address.ProvinceId,
                Street = address.Street,
                Province = address.Province,
            };
            if (model == null)
            {
                return false;
            }
           await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
