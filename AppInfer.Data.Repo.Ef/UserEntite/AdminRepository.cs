using AppDomainCore.UserEntite.Data;
using AppDomainCore.UserEntite.Dtos.AdminDtos;
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
    public class AdminRepository : IAdminRepository
    {
        private readonly AppDbContext _context;
        public AdminRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        

        public async Task<bool> Add(AdminCreateDto admin, CancellationToken cancellation)
        {
            var model = new Admin()
            {
               
                PhoneNumber = admin.PhoneNumber,
                Gender = admin.Gender,
            };
            if (model == null)
            {
                return false;
            }
            await _context.AddAsync(model,cancellation);
            await _context.SaveChangesAsync(cancellation);
           
            return true;
        }

        public async Task<bool> Delete(int adminId, CancellationToken cancellation)
        {
            var model = await _context.Admin.FirstOrDefaultAsync(x=>x.Id == adminId,cancellation);
            if (model == null)
            {
                return false;
            }
            model.IsDeleted = true;
            await _context.SaveChangesAsync(cancellation);
            return true;
        }

        

        public async Task<bool> Edit(int adminId, AdminUpdateDto admin, CancellationToken cancellation)
        {
            var model = await _context.Admin.Include(x => x.IsDeleted == false).FirstOrDefaultAsync(x => x.Id == adminId, cancellation);
            if (model == null)
            {
                return false;
            }
            model = new Admin()
            {
               
                FirstName = admin.FirstName,
                LastName = admin.LastName,
                Gender = admin.Gender,
                LastUpdated = DateTime.Now,
            };
            await _context.SaveChangesAsync(cancellation);
            return true;
        }

        public async Task<List<Admin>> GetAll(CancellationToken cancellation)
        {
            var models = await _context.Admin.Include(x => x.IsDeleted == false).ToListAsync(cancellation);
            return models;
        }

        public async Task<Admin> GetById(int adminId, CancellationToken cancellation)
        {
           var model = await _context.Admin.Include(x => x.IsDeleted == false).AsNoTracking().FirstOrDefaultAsync(x=>x.Id== adminId,cancellation);
            return model;
        }
    }
}
