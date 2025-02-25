using AppDomainCore.RequestEntite.Enums;
using AppDomainCore.SuggestionEntite.Date;
using AppDomainCore.SuggestionEntite.Dtos;
using AppDomainCore.SuggestionEntite.Entite;
using AppInfer.Db.Sql.Ef.Dbase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInfer.Data.Repo.Ef.SuggestionEntite
{
    public class SuggestionRepository : ISuggestionRepository
    {
        private readonly AppDbContext _context;
        public SuggestionRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
       

        public async Task<bool> Create(CeateSuggestionDto suggestion, CancellationToken cancellationToken)
        {
            var model = new Suggestion()
            {
                IsDeleted = false,
                CreatAt = DateTime.Now,
                Status = StatusEnum.WatingForCustomer,
                Description = suggestion.Description,
                Price = suggestion.Price,
                SuggestionDate = suggestion.SuggastionDate

            };
            if (model == null)
            {
                return false;
            }
            await _context.AddAsync(model,cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
           
            return true;
        }

        public async Task<bool> Delete(int suggestionId, CancellationToken cancellationToken)
        {
          var model = await _context.Suggestions.FirstOrDefaultAsync(x => x.Id == suggestionId,cancellationToken);
            if (model == null)
            {
                return false;
            }
            model.IsDeleted = true;
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<List<Suggestion>> GetAll(CancellationToken cancellationToken)
        {
            var models = await _context.Suggestions.Include(x => x.IsDeleted == false).AsNoTracking().ToListAsync(cancellationToken);
            return models;
        }

        public async Task<Suggestion> GetById(int id, CancellationToken cancellationToken)
        {
            var model = await _context.Suggestions.Include(x => x.IsDeleted == false).AsNoTracking().FirstOrDefaultAsync(x=>x.Id == id,cancellationToken);
            if (model == null)
            {
                return null;
            }
            return model;
        }

        

        public async Task<bool> Update(int suggestionId, UpdateSuggestionDto suggestion, CancellationToken cancellationToken)
        {
            var model = await _context.Suggestions.Include(x => x.IsDeleted == false).FirstOrDefaultAsync(x => x.Id == suggestionId, cancellationToken);
            if (model == null)
            {
                return false;
            }
            model = new Suggestion()
            {
                UpdateAt = DateTime.Now,
                Description = suggestion.Description,
                SuggestionDate = model.SuggestionDate,
                Price = suggestion.Price,
                Status = suggestion.Status,
            };
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
