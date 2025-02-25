using AppDomainCore.RequestEntite.Data;
using AppDomainCore.RequestEntite.Dtos;
using AppDomainCore.RequestEntite.Entite;
using AppDomainCore.RequestEntite.Enums;
using AppInfer.Db.Sql.Ef.Dbase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInfer.Data.Repo.Ef.RequestEntite
{
    public class RequestRepository : IRequestRepository
    {
        private readonly AppDbContext _context;
        public RequestRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public async Task<bool> ChangeStatus(StatusEnum status, int requestId, CancellationToken cancellationToken)
        {
            var req = await _context.Requests.Include(x => x.IsDeleted == false).FirstOrDefaultAsync(x => x.Id == requestId, cancellationToken);
            if (req == null)
            {
                return false;
            }
            req.Status = status;
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

        

        public async Task<bool> Create(RequestCreateDto request, CancellationToken cancellationToken)
        {
            var req = new Request()
            {
                CategoryServiceId = request.CategoryServiceId,
                CustomerId = request.CustomerId,
                DateRequest = DateTime.Now,
                Description = request.Description,
                Status = StatusEnum.WaitingForExperts,
                Titel = request.Title

            };
            if (req == null)
            {
                return false;
            }
            await _context.AddAsync(req, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }

        public async Task<bool> Delete(int requestId, CancellationToken cancellationToken)
        {
            var model = await _context.Requests.FirstOrDefaultAsync(x => x.Id == requestId, cancellationToken);
            if (model == null)
            {
                return false;
            }
            model.IsDeleted = true;
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<List<Request>> GetAll(CancellationToken cancellationToken)
        {
            var models = await _context.Requests.Include(x => x.IsDeleted == false).AsNoTracking().ToListAsync(cancellationToken);
            return models;
        }

        public async Task<Request> GetById(int id, CancellationToken cancellationToken)
        {
            var model = await _context.Requests.Include(x => x.IsDeleted == false).AsNoTracking().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            return model;
        }



       

        public async Task<bool> Update(int requestId, RequestUpdateDto request, CancellationToken cancellationToken)
        {
            var model = await _context.Requests.Include(x => x.IsDeleted == false).FirstOrDefaultAsync(x => x.Id == requestId, cancellationToken);
            if (model == null)
            {
                return false;
            }
            model = new Request()
            {
                CategoryServiceId = request.CategoryServiceId,
                Status = request.Status,
                DateRequest = DateTime.Now,
                ExpertId = request.ExpertId,
                Description = request.Description,
                Titel = request.Title,
                Location = request.Location

            };
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

        Task<GetRequestDto> IRequestRepository.GetById(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
